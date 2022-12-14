using System;
using System.Collections.Generic;
using Lessons.Architecture.Mechanics;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Lessons.Architecture.GameContexts
{
    public sealed class GameContext : MonoBehaviour
    {
        [ReadOnly]
        [ShowInInspector]
        private readonly List<object> listeners = new();

        [ReadOnly]
        [ShowInInspector]
        private readonly List<object> services = new();

        public T GetService<T>()
        {
            foreach (var service in this.services)
            {
                if (service is T result)
                {
                    return result;
                }
            }

            throw new Exception($"Service of type {typeof(T).Name} is not found!");
        }

        public void AddService(object service)
        {
            this.services.Add(service);
        }

        public void RemoveService(object service)
        {
            this.services.Remove(service);
        }

        public void AddListener(object listener)
        {
            this.listeners.Add(listener);
        }

        public void RemoveListener(object listener)
        {
            this.listeners.Remove(listener);
        }

     //   [Button]
        public void ConstructGame()
        {
            foreach (var listener in this.listeners)
            {
                if (listener is IConstructListener constructListener)
                {
                    constructListener.Construct(context: this);
                }
            }

            Debug.Log("Game Construct!");
        }

      //  [Button]
        public void StartGame()
        {
            foreach (var listener in this.listeners)
            {
                if (listener is IStartGameListener startListener)
                {
                    startListener.OnStartGame();
                }
            }

            Debug.Log("Game Started!");
        }

        [Button]
        public void PauseGame()
        {
            foreach (var listener in this.listeners)
            {
                if (listener is IPauseGameListener startListener)
                {
                    startListener.OnPauseGame();
                }
            }

            Debug.Log("Game Paused!");
        }

        [Button]
        public void ResumeGame()
        {
            foreach (var listener in this.listeners)
            {
                if (listener is IResumeGameListener startListener)
                {
                    startListener.OnResumeGame();
                }
            }

            Debug.Log("Game Resumed!");
        }

       // [Button]
        public void FinishGame()
        {
            foreach (var listener in this.listeners)
            {
                if (listener is IFinishGameListener finishListener)
                {
                    finishListener.OnFinishGame();
                }
            }

            Debug.Log("Game Finished!");
        }
    }
}