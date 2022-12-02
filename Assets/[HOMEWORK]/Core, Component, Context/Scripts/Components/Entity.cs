using System;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public sealed class Entity : MonoBehaviour, IEntity
    {
        [SerializeField]
        private MonoBehaviour[] components;
        private Entity entity;

        public T Get<T>()
        {
            for (int i = 0, count = this.components.Length; i < count; i++)
            {
                var component = this.components[i];
                if (component is T result)
                {
                    return result;
                }
            }

            throw new Exception($"Component of type {typeof(T).Name} is not found!");
        }

        public bool TryGet<T>(out T result)
        {
            for (int i = 0, count = this.components.Length; i < count; i++)
            {
                var component = this.components[i];
                if (component is T tComponent)
                {
                    result = tComponent;
                    return true;
                }
            }

            result = default;
            return false;
        }

       

        

        public T[] GetAll<T>()
        {
            throw new NotImplementedException();
        }

        public object[] GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(object element)
        {
            throw new NotImplementedException();
        }

        public void Remove(object element)
        {
            throw new NotImplementedException();
        }
    }
}