using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class AmmoMechanic : MonoBehaviour
    {
        [SerializeField]
        private IntBehaviour ammoPoints;

        [SerializeField]
        private IntBehaviour ammoPointsMax;

        [SerializeField]
        private EventReceiver reloadReceiver;

        [SerializeField]
        private TimerBehaviour countdown;

        private void OnEnable()
        {
            this.reloadReceiver.OnEvent += this.TryReload;
            this.countdown.OnEnded += Reload;
        }

        private void OnDisable()
        {
            this.reloadReceiver.OnEvent -= this.TryReload;
            this.countdown.OnEnded -= Reload;
        }


        public bool TrySpendAmmo()
        {
            if (this.countdown.IsPlaying)
            {
                return false;
            }

            if (ammoPoints.Value > 0)
            {
                this.ammoPoints.Value--;
                return true;
            } 
            else return false;
        }

        public void TryReload()
        {
            if (this.countdown.IsPlaying)
            {
                return;
            }

            if (ammoPoints.Value == ammoPointsMax.Value)
            {
                return;
            }

            this.countdown.ResetTime();
            this.countdown.Play();
        }

        private void Reload()
        {
            ammoPoints.Value = ammoPointsMax.Value;
        }
    }

}
