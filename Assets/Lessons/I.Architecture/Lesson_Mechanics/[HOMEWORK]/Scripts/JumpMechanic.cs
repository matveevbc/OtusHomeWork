using System;
using System.Collections;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class JumpMechanic : MonoBehaviour
    {
        [SerializeField]
        private EventReceiver startReciveir;

        [SerializeField]
        private Transform playerTransform;

        private float direction;

        [SerializeField]
        private float speed;

        [SerializeField]
        private float duration;

        private bool isJump;


        private void OnEnable()
        {
            this.startReciveir.OnEvent += this.StartJump;
        }

        private void OnDisable()
        {
            this.startReciveir.OnEvent -= this.StartJump;
        }

        void Update()
        {
            if(isJump)
                playerTransform.Translate(Vector3.up * direction);

        }

        public void StartJump()
        {
            StartCoroutine(Delay());
        }

        private IEnumerator Delay()
        {
            isJump = true;
            direction = speed;
            yield return new WaitForSecondsRealtime(duration);
            direction = -speed;
            yield return new WaitForSecondsRealtime(duration);
            direction = 0;
            isJump = false;
        }

    }
}