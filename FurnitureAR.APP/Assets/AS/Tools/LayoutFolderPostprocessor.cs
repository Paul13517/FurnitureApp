using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

#if UNITY_EDITOR

namespace Tools
{
    public class LayoutFolderPostprocessor : AssetPostprocessor
    {
        [MenuItem("Layouts/Build")]
        private static void DoSomething()
        {
            GenerateAssets();
        }
        
        private static String _lastScriptData = "";

        public static IReadOnlyList<String> GetAllPrefabs()
        {
            var assetPaths = AssetDatabase.GetAllAssetPaths();
            var result = new List<String>();
            foreach (var path in assetPaths)
            {
                if (path.Contains(".prefab"))
                {
                    result.Add(path);
                }
            }
            return result;
        }

        public static Boolean IsUnderDirectory(String fullpath, String directoryName)
        {
            return fullpath.Contains(String.Format(@"{0}/", directoryName));
        }

        public static String ToVariableName(String name)
        {
            var result = String.Join("", name.Where(it => Char.IsDigit(it) || Char.IsLetter(it))); ;

            if (result.Length <= 0)
            {
                throw new Exception($"Invalid naming: {name}");
            }

            if (Char.IsDigit(result[0]))
            {
                result = "n" + result;
            }

            return result;
        }

        private static void CreateBindingFile(IReadOnlyList<String> prefabs)
        {
            var codeBuilder = new BlockStringBuilder();

            codeBuilder.AppendLine("using System;");
            codeBuilder.AppendLine("using UnityEngine;");

            codeBuilder.AppendLine("namespace UserInterface.Generated");
            codeBuilder.Begin();

            codeBuilder.AppendLine("[ExecuteInEditMode]");

            codeBuilder.AppendLine("public class LayoutsContainer : MonoBehaviour");

            codeBuilder.Begin();

            var prefabToPathVar = new Dictionary<String, String>();

            {
                codeBuilder.AppendLine("#if UNITY_EDITOR");

                var usedNames = new Dictionary<String, Int32>();

                foreach (var prefab in prefabs)
                {
                    var fieldName = ToVariableName(Path.GetFileNameWithoutExtension(prefab)) + "Path";

                    if (usedNames.ContainsKey(fieldName))
                    {
                        usedNames[fieldName]++;
                        fieldName += usedNames[fieldName];
                    }
                    else
                    {
                        usedNames.Add(fieldName, 0);
                    }

                    prefabToPathVar.Add(prefab, fieldName);

                    codeBuilder.AppendLine($"private const String {fieldName} = \"{prefab}\";");
                }

                codeBuilder.AppendLine("#endif");
            }


            var pathVarToField = new Dictionary<String, String>();
            var fieldToProperty = new Dictionary<String, String>();

            {
                var usedNames = new Dictionary<String, Int32>();

                foreach (var prefab in prefabs)
                {
                    var fieldName = ToVariableName(Path.GetFileNameWithoutExtension(prefab));

                    var nonCapitalizedFileName = String.Copy(fieldName);

                    if (fieldName.Length > 1)
                    {
                        fieldName = Char.ToUpper(fieldName[0]) + fieldName.Substring(1);
                    }
                    else if (fieldName.Length == 1)
                    {
                        fieldName = Char.ToUpper(fieldName[0]).ToString();
                    }

                    if (nonCapitalizedFileName.Length > 1)
                    {
                        nonCapitalizedFileName = Char.ToLower(nonCapitalizedFileName[0]) + nonCapitalizedFileName.Substring(1);
                    }
                    else if (nonCapitalizedFileName.Length == 1)
                    {
                        nonCapitalizedFileName = Char.ToLower(nonCapitalizedFileName[0]).ToString();
                    }

                    if (usedNames.ContainsKey(fieldName))
                    {
                        usedNames[fieldName]++;
                        fieldName += usedNames[fieldName];
                    }
                    else
                    {
                        usedNames.Add(fieldName, 0);
                    }

                    pathVarToField.Add(prefab, nonCapitalizedFileName);

                    fieldToProperty.Add(nonCapitalizedFileName, fieldName);

                    codeBuilder.AppendLine($"[SerializeField] private GameObject _{nonCapitalizedFileName};");
                    codeBuilder.AppendLine($"public static GameObject {fieldName} {{ get; private set; }}");
                }
            }

            codeBuilder.AppendLine("private void Awake()");

            codeBuilder.Begin();

            foreach (var pair in fieldToProperty)
            {
                codeBuilder.AppendLine($"{pair.Value} = _{pair.Key};");
            }

            codeBuilder.End();

            codeBuilder.AppendLine("#if UNITY_EDITOR");

            codeBuilder.AppendLine("private void OnEnable()");

            codeBuilder.Begin();

            foreach (var pair in pathVarToField)
            {
                codeBuilder.AppendLine($"_{pair.Value} = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>(\"{pair.Key}\");");
            }

            codeBuilder.End();

            codeBuilder.AppendLine("#endif");

            codeBuilder.End();

            codeBuilder.End();

            var path = Path.Combine(Path.Combine(Path.Combine(Application.dataPath.Replace('/', Path.DirectorySeparatorChar), "AS"), "Generated"), "LayoutsContainer.cs");

            var code = codeBuilder.ToString();

            if(code == _lastScriptData)
            {
                return;
            }

            _lastScriptData = code;

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            File.WriteAllText(path, code);
        }

        private static String Capitalize(String str)
        {
            if (str is null)
                return null;
            
            if (str.Length > 1)
                str = Char.ToUpper(str[0]) + str.Substring(1);
            else if (str.Length == 1)
                str = Char.ToUpper(str[0]).ToString();
            
            return str;
        }
        
        private static String AntiCapitalize(String str)
        {
            if (str is null)
                return null;
            
            if (str.Length > 1)
                str = Char.ToLower(str[0]) + str.Substring(1);
            else if (str.Length == 1)
                str = Char.ToLower(str[0]).ToString();
            
            return str;
        }

        
        private static void GenerateGameObjectBinding(BlockStringBuilder codeBuilder, GameObject gameObject, String goPath, Dictionary<String, Int32> goNames, String parent)
        {


            var goFieldName = "_" + AntiCapitalize(ToVariableName(gameObject.name));
            var goPropertyName = Capitalize(ToVariableName(gameObject.name));

            var className = $"{goPropertyName}Binding";

            
            if (goNames.ContainsKey(goFieldName))
            {
                throw new Exception($"Ошибка при генерации {parent} / {className} Геймобджекты ${gameObject.name} имеют одинаковое имя!");
            }

            goNames.Add(goFieldName, 0);

            if (goPropertyName == "GameObject")
            {
                goFieldName += "_";
                goPropertyName += "_";
            }
            

            codeBuilder.AppendLine($"public class {className}");

            codeBuilder.Begin();

            codeBuilder.AppendLine("public readonly GameObject GameObject;");

            codeBuilder.AppendLine($"public {className}(GameObject gameObject) => GameObject = gameObject;");

            foreach (var component in gameObject.GetComponents(typeof(Component)))
            {
                if(component is null) 
                    return;
                
                var componentType = component.GetType().FullName;
                var componentName = component.GetType().Name;

                var fieldName = $"_{AntiCapitalize(componentName)}";
                codeBuilder.AppendLine($"private {componentType} {fieldName};");
                codeBuilder.AppendLine($"public {componentType} {componentName} => {fieldName} ??= GameObject.GetComponent<{componentType}>();");
            }
            
            codeBuilder.End();

            codeBuilder.AppendLine($"private {className} {goFieldName};");
            codeBuilder.AppendLine($"public {className} {goPropertyName} => {goFieldName} ??= new {className}(GameObject.transform.Find(\"{goPath}\").gameObject);");
        }

        private static void GenerateLayoutBinding(GameObject gameObject)
        {
            if (gameObject.GetComponent<IgnoreBinding>())
                return;
            
            var codeBuilder = new BlockStringBuilder();

            codeBuilder.AppendLine("using System;");
            codeBuilder.AppendLine("using UnityEngine;");

            codeBuilder.AppendLine("namespace Generated");
            codeBuilder.Begin();

            var className = $"{Capitalize(ToVariableName(gameObject.name))}Binding";
            codeBuilder.AppendLine($"public class {className}");
            
            codeBuilder.Begin();
            
            codeBuilder.AppendLine("public readonly GameObject GameObject;");
            
            foreach (var component in gameObject.GetComponents(typeof(Component)))
            {
                var componentType = component.GetType().FullName;
                var componentName = component.GetType().Name;

                var fieldName = $"_{AntiCapitalize(componentName)}";
                codeBuilder.AppendLine($"private {componentType} {fieldName};");
                codeBuilder.AppendLine($"public {componentType} {componentName} => {fieldName} ??= GameObject.GetComponent<{componentType}>();");
            }

            codeBuilder.AppendLine($"public {className}(GameObject gameObject) => GameObject = gameObject;");

            var goNames = new Dictionary<String, Int32>();
            
            void IterateChildrenRecursive(GameObject gameObject, String goPath)
            {
                if(gameObject.GetComponent<IgnoreBinding>())
                    return;
                
                GenerateGameObjectBinding(codeBuilder, gameObject, goPath, goNames, className);
                
                foreach (Transform child in gameObject.transform)
                    IterateChildrenRecursive(child.gameObject, goPath + "/" + child.name);
            }

            foreach (Transform child in gameObject.transform)
                IterateChildrenRecursive(child.gameObject, child.name);

            codeBuilder.End();
            codeBuilder.End();
            
            var path = Path.Combine(Path.Combine(Path.Combine(Application.dataPath.Replace('/', Path.DirectorySeparatorChar), "AS"), "Generated"), $"{className}.cs");

            var code = codeBuilder.ToString();
            
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            File.WriteAllText(path, code);
        }

        private static void GenerateAssets()
        {
            var prefabs = GetAllPrefabs();

            var layoutsPrefabs = new List<String>();

            foreach (var prefab in prefabs)
            {
                if (!IsUnderDirectory(prefab, "Layout")) 
                    continue;
                
                layoutsPrefabs.Add(prefab); 
                GenerateLayoutBinding(AssetDatabase.LoadAssetAtPath<GameObject>(prefab));
            }
            CreateBindingFile(layoutsPrefabs);
        }
    }
}

#endif
