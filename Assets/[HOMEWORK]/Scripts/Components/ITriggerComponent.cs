
using System;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public interface ITriggerComponent
    {
        void Trigger(Collider collider);
        public event Action<Collider> OnTrigger;
    }
}