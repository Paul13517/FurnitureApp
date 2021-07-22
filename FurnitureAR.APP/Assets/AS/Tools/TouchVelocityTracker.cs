using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Tools
{
    public class TouchVelocityTracker
    {
        private class TouchInfo
        {
            public readonly Vector3 Position;
            public Single Time;

            public TouchInfo(Vector3 position, Single time)
            {
                Position = position;
                Time = time;
            }
        }
        
        private Queue<TouchInfo> TouchesHistory = new Queue<TouchInfo>();
        
        public void PushTouch(Vector3 mousePosition)
        {
            if (TouchesHistory.Count > 1000)
            {
                TouchesHistory.Dequeue();
            }

            foreach (var touchData in TouchesHistory)
            {
                touchData.Time += Time.deltaTime;
            }
            TouchesHistory.Enqueue(new TouchInfo(Input.mousePosition, 0.0f));
        }

        public void Reset() => TouchesHistory.Clear();

        public Single ComputeVelocity(Single sliceTimeSeconds)
        {
            if (TouchesHistory.Count <= 1)
            {
                return 0.0f;
            }
            
            if (sliceTimeSeconds == 0)
            {
                throw new Exception("Время отсечения не может быть равно 0!");
            }

            var touchesPositions = 
                TouchesHistory.
                Where(touchInfo => touchInfo.Time <= sliceTimeSeconds).
                Select(touchInfoWithNeededTime => touchInfoWithNeededTime.Position).
                ToList();

            var sumDistance = 0.0f;
            
            for (var i = 0; i < touchesPositions.Count - 1; i += 2)
            {
                sumDistance += Vector2.Distance(touchesPositions[i], touchesPositions[i + 1]);
            }
            
            sumDistance +=
                Vector2.Distance(touchesPositions[touchesPositions.Count - 2], touchesPositions[touchesPositions.Count - 1]);

            return sumDistance / sliceTimeSeconds;
        }
    }
}