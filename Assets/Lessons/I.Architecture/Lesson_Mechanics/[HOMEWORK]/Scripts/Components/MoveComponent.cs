using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public sealed class MoveComponent : MonoBehaviour, IMoveComponent
    {
        [SerializeField]
        private DirectionEventReciever moveReceiver;

        public void Move(Direction direction)
        {
            this.moveReceiver.Call(direction);
        }
    }
}