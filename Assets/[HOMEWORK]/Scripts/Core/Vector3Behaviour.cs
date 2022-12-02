using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class Vector3Behaviour : MonoBehaviour
    {
        public event Action<Vector3> OnValueChanged;

        public Vector3 Value
        {
            get { return this.value; }
            set
            {
                this.value = value;
                this.OnValueChanged?.Invoke(value);
            }
        }

        [SerializeField]
        private Vector3 value;
    }
}


