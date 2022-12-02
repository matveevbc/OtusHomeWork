using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class TrigerBehaviour : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            BoarderObserver.OnTriggerEnter(other);
        }

    }

}
