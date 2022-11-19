using System.Collections;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class JumpMechanic : MonoBehaviour
    {
        [SerializeField]
        private EventReceiver startReceiver;

        [SerializeField]
        private JumpEngine jumpEngine;

        private void OnEnable()
        {
            this.startReceiver.OnEvent += this.jumpEngine.StartJump;
        }

        private void OnDisable()
        {
            this.startReceiver.OnEvent -= this.jumpEngine.StartJump;
        }

        

      

    }
}