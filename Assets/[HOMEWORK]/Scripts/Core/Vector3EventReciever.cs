using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public sealed class Vector3EventReciever : MonoBehaviour
    {
        public event Action<Vector3> OnEvent;

        [Button]
        public void Call(Vector3 value)
        {
            this.OnEvent?.Invoke(value);
        }
    }
}

