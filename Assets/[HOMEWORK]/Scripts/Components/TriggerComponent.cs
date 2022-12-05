using System;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public sealed class TriggerComponent : MonoBehaviour, ITriggerComponent
    {
        [SerializeField]
        private TrigerBehaviour trigerBehaviour;

        public event Action<Collider> OnTrigger;

        private void OnEnable()
        {
            trigerBehaviour.OnTriggerEntered += Trigger;
        }

        private void OnDisable()
        {
            trigerBehaviour.OnTriggerEntered -= Trigger;
        }

        public void Trigger(Collider collider)
        {
            OnTrigger?.Invoke(collider);
        }
    }
}