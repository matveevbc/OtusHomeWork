using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Teacher.Architecture.Mechanics
{
    public sealed class IntEventReceiver : MonoBehaviour
    {
        public event Action<int> OnEvent;

        [Button]
        public void Call(int value)
        {
            this.OnEvent?.Invoke(value);
        }
    }
}