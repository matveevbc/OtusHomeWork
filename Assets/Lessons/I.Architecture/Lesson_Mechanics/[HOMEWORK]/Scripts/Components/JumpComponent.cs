using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public sealed class JumpComponent : MonoBehaviour, IJumpComponent
    {
        [SerializeField]
        private EventReceiver jumpReceiver;

        public void Jump()
        {
            this.jumpReceiver.Call();
        }
    }
}