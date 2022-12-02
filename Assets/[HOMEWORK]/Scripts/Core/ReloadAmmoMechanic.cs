using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class ReloadAmmoMechanic : MonoBehaviour
    {
       
        [SerializeField]
        private EventReceiver reloadReceiver;

        [SerializeField]
        private TimerBehaviour countdown;

        [SerializeField]
        private AmmoEngine ammoEngine;

       private void OnEnable()
        {
            this.reloadReceiver.OnEvent += this.TryReload;
            this.countdown.OnEnded += this.ammoEngine.Reload;
        }

        private void OnDisable()
        {
            this.reloadReceiver.OnEvent -= this.TryReload;
            this.countdown.OnEnded -= this.ammoEngine.Reload;
        }



        public void TryReload()
        {
            if (this.countdown.IsPlaying)
            {
                return;
            }

            if (ammoEngine.IsFull())
            {
                return;
            }

            this.countdown.ResetTime();
            this.countdown.Play();
        }

    }

}
