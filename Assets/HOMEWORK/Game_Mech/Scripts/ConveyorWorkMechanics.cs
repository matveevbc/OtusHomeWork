using System;
using Elementary;
using UnityEngine;

namespace Lessons.Gameplay.Mech
{
    public sealed class ConveyorWorkMechanics : MonoBehaviour
    {
        [Space]
        [SerializeField]
        private TimerBehaviour workTimer;

        [SerializeField]
        private IntBehaviourLimited woodStorage;

        [SerializeField]
        private IntBehaviourLimited stoneStorage;

        [SerializeField]
        private IntBehaviourLimited outputStorage;

        private void OnEnable()
        {
            this.workTimer.OnFinished += this.OnWorkFinished;
        }

        private void OnDisable()
        {
            this.workTimer.OnFinished -= this.OnWorkFinished;
        }

        private void Update()
        {
            if (this.CanStartWork())
            {
                this.StartWork();
            }
        }

        private bool CanStartWork()
        {
            if (this.woodStorage.Value < 5)
            {
                return false;
            }

            if (this.stoneStorage.Value < 5)
            {
                return false;
            }

            if (this.outputStorage.IsLimit)
            {
                return false;
            }

            if (this.workTimer.IsPlaying)
            {
                return false;
            }
            
            return true;
        }

        private void StartWork()
        {
            this.woodStorage.Value -= 5;
            this.stoneStorage.Value -= 5;
            this.workTimer.ResetTime();
            this.workTimer.Play();
        }

        private void OnWorkFinished()
        {
            this.outputStorage.Value++;
        }
    }
}