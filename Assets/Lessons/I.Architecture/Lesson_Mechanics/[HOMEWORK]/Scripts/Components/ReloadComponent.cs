using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public sealed class ReloadComponent : MonoBehaviour, IReloadComponent
    {
        [SerializeField]
        private EventReceiver reloadReceiver;

        public void Reload()
        {
            this.reloadReceiver.Call();
        }
    }
}