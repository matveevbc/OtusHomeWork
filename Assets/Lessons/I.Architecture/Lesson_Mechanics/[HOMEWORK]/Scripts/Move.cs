using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class Move : MonoBehaviour
    {

        [SerializeField]
        private Direction direction;

        private Transform transform;

        public event Action OnEnded;

        private bool isMoving;

        [SerializeField]
        private float speed;


        public void Play(Transform _t)
        {
            transform = _t;
            isMoving = true;
            StartCoroutine(this.TimerRoutine());
        }

        public void Stop()
        {
            isMoving = false;
        }


        private IEnumerator TimerRoutine()
        {
            while (isMoving)// this.movingCoroutine != null
            {
                switch (direction)
                {
                    case Direction.Forward:
                        transform.Translate(Vector3.forward * speed);
                        break;
                    case Direction.Backward:
                        transform.Translate(Vector3.back * speed);
                        break;
                    case Direction.LeftStep:
                        transform.Translate(Vector3.left * speed);
                        break;
                    case Direction.RightStep:
                        transform.Translate(Vector3.right * speed);
                        break;
                    case Direction.RotateLeft:
                        transform.Rotate(Vector3.up, speed);
                        break;
                    case Direction.RotateRight:
                        transform.Rotate(Vector3.up, -speed);
                        break;
                }
                yield return null;
            }

            this.OnEnded?.Invoke();
        }
    }
}



