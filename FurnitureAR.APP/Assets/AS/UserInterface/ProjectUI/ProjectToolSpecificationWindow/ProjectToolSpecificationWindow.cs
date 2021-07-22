using System;
using Generated;
using S123.Models.Project;
using TMPro;
using Tools.WindowSystem;
using UniRx;
using UnityEngine;
using UserInterface.Generated;
using Object = UnityEngine.Object;

namespace UserInterface.ProjectUI
{

    public class ProjectToolSpecificationWindow : Window
    {
        public ProjectToolSpecificationWindowBinding Binding { private set; get; }
        
        private ProjectViewModel _viewModel;

        private Transform[] _inputsItemHolders;
        
        public ProjectToolSpecificationWindow(ProjectViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        protected override GameObject CreateView()
        {
            var layout = Object.Instantiate(LayoutsContainer.ProjectToolSpecificationWindow);

            var binding = new ProjectToolSpecificationWindowBinding(layout);
            
            Binding = binding;
            
            _viewModel.InputFieldsCount
                .Subscribe(count =>
                {
                    CreateOutputItems(binding.Content.RectTransform, count);
                    for (var i = 0; i < count; i++)
                    {
                        var fieldCallback = new ReactiveCommand<(Int32 index, AttributeField field)>();
                        fieldCallback.Subscribe(it => CreateAttributeField(it.index, it.field)).AddTo(_inputsItemHolders[i]);
                        _viewModel.RequestInputFieldAt(i, fieldCallback);
                    }
                })
                .AddTo(layout);

            _viewModel.LoadStatus
                .Subscribe(binding.LoadErrorBar.LoadStatusBarController.SetStatus)
                .AddTo(layout);
            
            binding.RecomputeButton.Button.onClick.AddListener(() =>
            {
                var recomputeCallback = new ReactiveProperty<(Project, String error)?>();
                
                _viewModel.Recompute(recomputeCallback);  
                
            //    GetWindowsHolder(holder => 
            //        holder.AttachWindow(new ProjectWindow(recomputeCallback, this, _viewModel.ProjectName.Value + " (Пересчитанный)")));
            });

            
            
            return layout;
        }
        
        private void CreateOutputItems(Transform root, Int32 count)
        {
            _inputsItemHolders = new Transform[count];
            for (var i = 0; i < count; i++)
            {
                var go = new GameObject("ItemHolder");
                var rectTransform = go.AddComponent<RectTransform>();
                rectTransform.sizeDelta = new Vector2(0.0f, LayoutsContainer.TextFieldReadOnlyLayout.GetComponent<RectTransform>().sizeDelta.y);
                go.transform.SetParent(root, false);
                _inputsItemHolders[i] = go.transform;
            }
        }
        
        private void CreateAttributeField(Int32 index, AttributeField attributeField)
        {

            switch (attributeField)
            {
                case TextAttributeField textField:
                {
                    var fieldGameObject = Object.Instantiate(LayoutsContainer.TextFieldInputLayout, _inputsItemHolders[index], false);

                    var fieldBinding = new TextFieldInputLayoutBinding(fieldGameObject);
                    
                    fieldBinding.TitleText.TextMeshProUGUI.text = textField.Name;

                    var inputField = fieldBinding.InputField.TMP_InputField;

                    inputField.text = attributeField.Value.Value;

                    inputField.characterValidation = textField.Type switch
                    {
                        TextAttributeFieldType.String => TMP_InputField.CharacterValidation.None,
                        TextAttributeFieldType.Single => TMP_InputField.CharacterValidation.Decimal,
                        TextAttributeFieldType.Integer => TMP_InputField.CharacterValidation.Integer,
                        _ => inputField.characterValidation
                    };

                    inputField.onValueChanged.AddListener(attributeField.UpdateValue);
                    break;
                }
                case TreeAttributeField treeField:
                {
                    var fieldGameObject = Object.Instantiate(LayoutsContainer.TreeFieldInputLayout, _inputsItemHolders[index], false);

                    var fieldBinding = new TreeFieldInputLayoutBinding(fieldGameObject);

                    fieldBinding.TitleText.TextMeshProUGUI.text = treeField.Name;

                    treeField.Value.Subscribe(newValue => 
                        fieldBinding.ValueText.TextMeshProUGUI.text = newValue)
                        .AddTo(fieldGameObject);
                    
                    treeField.Icon.Subscribe(sprite =>
                        fieldBinding.Icon.Image.sprite = sprite)
                        .AddTo(fieldGameObject);
                
                    // fieldGameObject.GetComponentInChildren<Button>().onClick.AddListener(() =>
                    //     GetWindowsHolder(holder => 
                    //         holder.AttachWindow(new ProjectTreeAttributeWindow.ProjectTreeAttributeWindow(treeField, null))
                    //     )
                    // );
                    break;
                }
            }
        }
    }

}
