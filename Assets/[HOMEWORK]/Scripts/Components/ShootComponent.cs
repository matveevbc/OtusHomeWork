using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public sealed class ShootComponent : MonoBehaviour, IShootComponent
    {
        [SerializeField]
        private EventReceiver shootReceiver;

        public void Shoot()
        {
            this.shootReceiver.Call();
        }
    }
}