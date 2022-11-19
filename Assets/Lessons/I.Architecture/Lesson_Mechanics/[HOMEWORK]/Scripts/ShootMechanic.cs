using System;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class ShootMechanic : MonoBehaviour
    {
        [SerializeField]
        private EventReceiver shoot;

        [SerializeField]
        private TimerBehaviour countdown;

        [SerializeField]
        private BulletSpawner bulletSpawner;

        [SerializeField]
        private AmmoEngine ammoEngine;

        [SerializeField]
        private TimerBehaviour reloadTimer;

       private void OnEnable()
        {
            this.shoot.OnEvent += this.OnShootRequest;
        }

        private void OnDisable()
        {
            this.shoot.OnEvent -= this.OnShootRequest;
        }

        public void OnShootRequest()
        {
            if (this.reloadTimer.IsPlaying)
            {
                return;
            }

            if (this.countdown.IsPlaying)
            {
                return;
            }

            if (!this.ammoEngine.TrySpendPoint())
            {
                return;
            }

            bulletSpawner.Spawn();

            this.countdown.ResetTime();
            this.countdown.Play();
        }
    }

}

