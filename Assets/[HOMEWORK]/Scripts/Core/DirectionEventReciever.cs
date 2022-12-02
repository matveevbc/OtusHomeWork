using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public sealed class DirectionEventReciever : MonoBehaviour
    {
        public event Action<Direction> OnEvent;

        [Button]
        public void Call(Direction dir)
        {
            Debug.Log($"Event {name} was received!");
            this.OnEvent?.Invoke(dir);
        }
    }
}