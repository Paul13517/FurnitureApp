using System;
using UnityEngine;
namespace UserInterface.Generated
{
    [ExecuteInEditMode]
    public class LayoutsContainer : MonoBehaviour
    {
        #if UNITY_EDITOR
        private const String ARModulePath = "Assets/AS/UserInterface/ProjectUI/ProjectARWindow/Layout/ARModule.prefab";
        private const String TreeFieldInputLayoutPath = "Assets/AS/UserInterface/ProjectUI/AttributeFields/TreeField/Layout/TreeFieldInputLayout.prefab";
        private const String GridElementTempPath = "Assets/AS/UserInterface/ProjectUI/ProjectTreeAttributeWindow/GridItem/Layout/GridElementTemp.prefab";
        private const String LaunchScreenWindowPath = "Assets/AS/UserInterface/LaunchScreen/Layout/LaunchScreenWindow.prefab";
        private const String ProjectTreeAttributeWindowPath = "Assets/AS/UserInterface/ProjectUI/ProjectTreeAttributeWindow/Layout/ProjectTreeAttributeWindow.prefab";
        private const String Project3DViewWindowPath = "Assets/AS/UserInterface/ProjectUI/Project3DView/Layout/Project3DViewWindow.prefab";
        private const String TreeFieldReadOnlyLayoutPath = "Assets/AS/UserInterface/ProjectUI/AttributeFields/TreeField/Layout/TreeFieldReadOnlyLayout.prefab";
        private const String AuthWindowPath = "Assets/AS/UserInterface/AuthWindow/Layout/AuthWindow.prefab";
        private const String Project2DViewWindowPath = "Assets/AS/UserInterface/ProjectUI/Project2DViewWindow/Layout/Project2DViewWindow.prefab";
        private const String ProjectWindowPortraitLayoutPath = "Assets/AS/UserInterface/ProjectUI/ProjectWindow/Layout/ProjectWindowPortraitLayout.prefab";
        private const String DirectoryTreeListElementPath = "Assets/AS/UserInterface/DirectoryTreeUI/ListElement/Layout/DirectoryTreeListElement.prefab";
        private const String TextFieldReadOnlyLayoutPath = "Assets/AS/UserInterface/ProjectUI/AttributeFields/TextField/Layout/TextFieldReadOnlyLayout.prefab";
        private const String ProjectToolSpecificationWindowPath = "Assets/AS/UserInterface/ProjectUI/ProjectToolSpecificationWindow/Layout/ProjectToolSpecificationWindow.prefab";
        private const String ToolSpecsBarPath = "Assets/AS/UserInterface/ProjectUI/ProjectWindow/Layout/ToolSpecsBar.prefab";
        private const String TextFieldInputLayoutPath = "Assets/AS/UserInterface/ProjectUI/AttributeFields/TextField/Layout/TextFieldInputLayout.prefab";
        private const String ProjectARViewWindowPath = "Assets/AS/UserInterface/ProjectUI/ProjectARWindow/Layout/ProjectARViewWindow.prefab";
        private const String DirectoryTreeWindowLayoutPath = "Assets/AS/UserInterface/DirectoryTreeUI/Layout/DirectoryTreeWindowLayout.prefab";
        #endif
        [SerializeField] private GameObject _aRModule;
        public static GameObject ARModule { get; private set; }
        [SerializeField] private GameObject _treeFieldInputLayout;
        public static GameObject TreeFieldInputLayout { get; private set; }
        [SerializeField] private GameObject _gridElementTemp;
        public static GameObject GridElementTemp { get; private set; }
        [SerializeField] private GameObject _launchScreenWindow;
        public static GameObject LaunchScreenWindow { get; private set; }
        [SerializeField] private GameObject _projectTreeAttributeWindow;
        public static GameObject ProjectTreeAttributeWindow { get; private set; }
        [SerializeField] private GameObject _project3DViewWindow;
        public static GameObject Project3DViewWindow { get; private set; }
        [SerializeField] private GameObject _treeFieldReadOnlyLayout;
        public static GameObject TreeFieldReadOnlyLayout { get; private set; }
        [SerializeField] private GameObject _authWindow;
        public static GameObject AuthWindow { get; private set; }
        [SerializeField] private GameObject _project2DViewWindow;
        public static GameObject Project2DViewWindow { get; private set; }
        [SerializeField] private GameObject _projectWindowPortraitLayout;
        public static GameObject ProjectWindowPortraitLayout { get; private set; }
        [SerializeField] private GameObject _directoryTreeListElement;
        public static GameObject DirectoryTreeListElement { get; private set; }
        [SerializeField] private GameObject _textFieldReadOnlyLayout;
        public static GameObject TextFieldReadOnlyLayout { get; private set; }
        [SerializeField] private GameObject _projectToolSpecificationWindow;
        public static GameObject ProjectToolSpecificationWindow { get; private set; }
        [SerializeField] private GameObject _toolSpecsBar;
        public static GameObject ToolSpecsBar { get; private set; }
        [SerializeField] private GameObject _textFieldInputLayout;
        public static GameObject TextFieldInputLayout { get; private set; }
        [SerializeField] private GameObject _projectARViewWindow;
        public static GameObject ProjectARViewWindow { get; private set; }
        [SerializeField] private GameObject _directoryTreeWindowLayout;
        public static GameObject DirectoryTreeWindowLayout { get; private set; }
        private void Awake()
        {
            ARModule = _aRModule;
            TreeFieldInputLayout = _treeFieldInputLayout;
            GridElementTemp = _gridElementTemp;
            LaunchScreenWindow = _launchScreenWindow;
            ProjectTreeAttributeWindow = _projectTreeAttributeWindow;
            Project3DViewWindow = _project3DViewWindow;
            TreeFieldReadOnlyLayout = _treeFieldReadOnlyLayout;
            AuthWindow = _authWindow;
            Project2DViewWindow = _project2DViewWindow;
            ProjectWindowPortraitLayout = _projectWindowPortraitLayout;
            DirectoryTreeListElement = _directoryTreeListElement;
            TextFieldReadOnlyLayout = _textFieldReadOnlyLayout;
            ProjectToolSpecificationWindow = _projectToolSpecificationWindow;
            ToolSpecsBar = _toolSpecsBar;
            TextFieldInputLayout = _textFieldInputLayout;
            ProjectARViewWindow = _projectARViewWindow;
            DirectoryTreeWindowLayout = _directoryTreeWindowLayout;
        }
        #if UNITY_EDITOR
        private void OnEnable()
        {
            _aRModule = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/ProjectUI/ProjectARWindow/Layout/ARModule.prefab");
            _treeFieldInputLayout = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/ProjectUI/AttributeFields/TreeField/Layout/TreeFieldInputLayout.prefab");
            _gridElementTemp = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/ProjectUI/ProjectTreeAttributeWindow/GridItem/Layout/GridElementTemp.prefab");
            _launchScreenWindow = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/LaunchScreen/Layout/LaunchScreenWindow.prefab");
            _projectTreeAttributeWindow = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/ProjectUI/ProjectTreeAttributeWindow/Layout/ProjectTreeAttributeWindow.prefab");
            _project3DViewWindow = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/ProjectUI/Project3DView/Layout/Project3DViewWindow.prefab");
            _treeFieldReadOnlyLayout = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/ProjectUI/AttributeFields/TreeField/Layout/TreeFieldReadOnlyLayout.prefab");
            _authWindow = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/AuthWindow/Layout/AuthWindow.prefab");
            _project2DViewWindow = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/ProjectUI/Project2DViewWindow/Layout/Project2DViewWindow.prefab");
            _projectWindowPortraitLayout = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/ProjectUI/ProjectWindow/Layout/ProjectWindowPortraitLayout.prefab");
            _directoryTreeListElement = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/DirectoryTreeUI/ListElement/Layout/DirectoryTreeListElement.prefab");
            _textFieldReadOnlyLayout = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/ProjectUI/AttributeFields/TextField/Layout/TextFieldReadOnlyLayout.prefab");
            _projectToolSpecificationWindow = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/ProjectUI/ProjectToolSpecificationWindow/Layout/ProjectToolSpecificationWindow.prefab");
            _toolSpecsBar = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/ProjectUI/ProjectWindow/Layout/ToolSpecsBar.prefab");
            _textFieldInputLayout = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/ProjectUI/AttributeFields/TextField/Layout/TextFieldInputLayout.prefab");
            _projectARViewWindow = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/ProjectUI/ProjectARWindow/Layout/ProjectARViewWindow.prefab");
            _directoryTreeWindowLayout = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>("Assets/AS/UserInterface/DirectoryTreeUI/Layout/DirectoryTreeWindowLayout.prefab");
        }
        #endif
    }
}
