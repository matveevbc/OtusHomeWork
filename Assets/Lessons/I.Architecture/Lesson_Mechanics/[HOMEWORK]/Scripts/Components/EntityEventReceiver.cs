using System;
using Entities;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public sealed class EntityEventReceiver : MonoBehaviour
    {
        public event Action<Entity> OnEvent;

        [Button]
        public void Call(Entity entity)
        {
            this.OnEvent?.Invoke(entity);
        }
    }
}