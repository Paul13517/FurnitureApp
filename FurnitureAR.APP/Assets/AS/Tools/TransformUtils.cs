using System;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public static class TransformUtils
    {
        public static IReadOnlyList<Transform> FindChildrenRecursive(this Transform transform, String findName)
        {
            var stack = new Stack<Transform>();
            
            var findResult = new List<Transform>();
            
            stack.Push(transform);

            while (stack.Count > 0)
            {
                foreach (Transform childTransform in stack.Pop())
                {
                    if (childTransform.name == findName)
                    {
                        findResult.Add(childTransform);
                    }
                    stack.Push(childTransform);
                }
            }

            return findResult;
        }
        
        public static Transform FindChildRecursive(this Transform transform, String findName)
        {
            var stack = new Stack<Transform>();
            
            stack.Push(transform);

            while (stack.Count > 0)
            {
                foreach (Transform childTransform in stack.Pop())
                {
                    if (childTransform.name == findName)
                    {
                        return childTransform;
                    }
                    stack.Push(childTransform);
                }
            }
            
            return null;
        }
    }
}