using System;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class ShootMechanic : MonoBehaviour
    {
        public event Action OnEnded;

        [SerializeField]
        private EventReceiver shoot;

        [SerializeField]
        private TimerBehaviour countdown;

        [SerializeField]
        private GameObject prefab;

        [SerializeField]
        private Transform player;

        [SerializeField]
        private Spawner spawner;

        [SerializeField]
        private AmmoMechanic ammo;


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
            if (this.countdown.IsPlaying)
            {
                return;
            }

            if (!this.ammo.TrySpendAmmo())
            {
                return;
            }

            spawner.Spawn(prefab, player);

            this.countdown.ResetTime();
            this.countdown.Play();
            this.OnEnded?.Invoke();
        }
    }

}

