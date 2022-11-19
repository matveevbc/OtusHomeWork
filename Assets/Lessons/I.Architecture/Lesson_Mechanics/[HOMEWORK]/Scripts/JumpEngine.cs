using System.Collections;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class JumpEngine : MonoBehaviour
    {
        [SerializeField]
        private Transform playerTransform;
         
        [SerializeField]
        private float speed;

        [SerializeField]
        private float duration;

        private bool isJump;

        private float direction;

        public void StartJump()
        {
            StartCoroutine(Delay());
        }

        private void Update()
        {
            if (isJump)
                playerTransform.Translate(Vector3.up * direction * Time.deltaTime);

        }

        
        private IEnumerator Delay()
        {
            isJump = true;
            direction = speed;
            yield return new WaitForSeconds(duration);
            direction = -speed;
            yield return new WaitForSeconds(duration);
            direction = 0;
            isJump = false;
        }
    }

}
