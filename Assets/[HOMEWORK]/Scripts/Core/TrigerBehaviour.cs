using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class TrigerBehaviour : MonoBehaviour
    {
        public event Action<Collider> OnTriggerEntered;

        public void OnTriggerEnter(Collider other)
        {
            OnTriggerEntered?.Invoke(other);
        }
    }
}
