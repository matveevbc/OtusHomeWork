using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class MoveController : MonoBehaviour
    {
        [SerializeField]
        private Entity unit;

        private void Update()
        {
          this.HandleKeyboard();
        }
        
        private void HandleKeyboard()
        {
            if (Input.GetKey(KeyCode.W))
            {
                this.Move(Direction.Forward);
            }
             else if (Input.GetKey(KeyCode.S))
                 {
                     this.Move(Direction.Backward);
                 }
             else if (Input.GetKey(KeyCode.A))
                 {
                     this.Move(Direction.LeftStep);
                 }
             else if (Input.GetKey(KeyCode.D))
                 {
                     this.Move(Direction.RightStep);
                 }
             else if (Input.GetKey(KeyCode.Q))
                 {
                    this.Move(Direction.RotateLeft);
                 }
             else if (Input.GetKey(KeyCode.E))
                {
                    this.Move(Direction.RotateRight);
                }
        }

        private void Move(Direction dir)
        {
            unit.Get<MoveComponent>().Move(dir);
        }

    }
}

