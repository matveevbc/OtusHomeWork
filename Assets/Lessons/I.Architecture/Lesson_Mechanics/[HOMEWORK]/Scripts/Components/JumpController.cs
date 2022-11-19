
using UnityEngine;


namespace Lessons.Architecture.Mechanics
{
    public class JumpController : MonoBehaviour
    {
        [SerializeField]
        private Entity unit;

        private void Update()
        {
            this.HandleKeyboard();
        }

        private void HandleKeyboard()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                this.Jump();
            }
        }

        private void Jump()
        {
            unit.Get<JumpComponent>().Jump();
        }
    }

}

