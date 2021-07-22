using System;
using System.Collections.Generic;
using AS.Tools;
using S123.Models.Tree;
using UniRx;
using UnityEngine;

namespace UserInterface.DirectoryTreeUI
{
    public struct DirectoryInfo
    {
        public readonly Int32 Id;

        public readonly String Name;

        public readonly S123Type Type;

        public DirectoryInfo(Int32 id, S123Type type, String name)
            => (Id, Type, Name) = (id, type, name);
    }
    
    public class DirectoryTreeViewModel : ViewModelForNetwork
    {
        public IReactiveProperty<String> DirectoryName => _directoryName;

        public IReactiveProperty<Int32> ChildCount => _childCount;
        
        public IReactiveProperty<Int32> DirectoryId => _directoryId;

        private readonly ReactivePropertyNoInit<Int32> _directoryId = new ReactivePropertyNoInit<Int32>();
        
        private readonly ReactivePropertyNoInit<String> _directoryName = new ReactivePropertyNoInit<String>();
        
        private readonly ReactivePropertyNoInit<Int32> _childCount = new ReactivePropertyNoInit<Int32>();
        
        private readonly AsyncCacheBuffer<Int32, Sprite> _icons = new AsyncCacheBuffer<Int32, Sprite>();
        
        private readonly AsyncCacheBuffer<Int32, Directory> _relocatedDirectories = new AsyncCacheBuffer<Int32, Directory>();
        
        private List<Directory> _childrenDirectories;

        public DirectoryTreeViewModel(Int32 directoryId) => InitDirectory(directoryId);

        public async void RequestChildDataAt(
            Int32 index,    
            ReactiveCommand<(Int32 index, DirectoryInfo id)> onChildDirectoryInfoLoaded, 
            ReactiveCommand<(Int32 index, Sprite sprite)> onChildIconLoaded)
        {
            try
            {
                await base.WaitForInit();
                
                LoadChild(index, onChildDirectoryInfoLoaded, onChildIconLoaded);
            }
            catch(Exception exception)
            {
                if (exception is OperationCanceledException)
                    Debug.Log($"Остановка загрузки элемента списка {index} директории {_directoryName}");
                else
                    Debug.LogError(exception.Message);
            }
        }
        
        private async void InitDirectory(Int32 directoryId)
        {
            try
            {
                var directory = await Directory.Get(directoryId, base.CancellationToken);
                
                _directoryId.SetValueAndForceNotify(directoryId);
                
                directory = await directory.GetSelfOrRelocation(base.CancellationToken);

                var childrenDirectories = await directory.GetChildren( false, base.CancellationToken );

                _childrenDirectories = childrenDirectories;
                
                base.SetLoadStatus(UserInterface.LoadStatus.Success);
                base.SetInitComplete();

                _childCount.SetValueAndForceNotify(childrenDirectories.Count);
                _directoryName.SetValueAndForceNotify(directory.Name);
                
            }
            catch(Exception exception)
            {
                if (exception is OperationCanceledException)
                    Debug.Log($"Остановка загрузки директории!");
                else
                {
                    SetLoadStatus(UserInterface.LoadStatus.Error);
                    Debug.LogError(exception.Message);
                }
                CancelLoading();
            }
        }

        private async void LoadChild(Int32 index, 
            IReactiveCommand<(Int32 index, DirectoryInfo id)> onChildDirectoryInfoLoaded, 
            IReactiveCommand<(Int32 index, Sprite sprite)> onChildIconLoaded)
        {
            try
            {
                var directory = _childrenDirectories[index];
                
                directory = await _relocatedDirectories.Get(index, directory.GetSelfOrRelocation(base.CancellationToken));
                
                onChildDirectoryInfoLoaded?.Execute((index, new DirectoryInfo(directory.Id, directory.Type, directory.Name)));
                
                try
                {
                    onChildIconLoaded?.Execute((index, await _icons.Get(index, RestController.GetIcon(directory, base.CancellationToken))));
                }
                catch(Exception exception)
                {  
                    if (exception is OperationCanceledException)
                        Debug.Log($"Остановка загрузки иконки элемента списка {index} директории {DirectoryName}");
                    else
                        Debug.LogError(exception.Message);
                }
            }
            catch(Exception exception)
            {  
                if (exception is OperationCanceledException)
                    Debug.Log($"Остановка загрузки дочернего элемента {index} директории {DirectoryName}");
                else
                    Debug.LogError(exception.Message);
            }
        }
        
    }
}
