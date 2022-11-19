using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class MoveEngine : MonoBehaviour
    {

        [SerializeField]
        private Direction direction;

        [SerializeField]
        private Transform movetransform;

        private bool isMoving;

        [SerializeField]
        private float speed;


        public void Play()
        {
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
                        movetransform.Translate(Vector3.forward * speed);
                        break;
                    case Direction.Backward:
                        movetransform.Translate(Vector3.back * speed);
                        break;
                    case Direction.LeftStep:
                        movetransform.Translate(Vector3.left * speed);
                        break;
                    case Direction.RightStep:
                        movetransform.Translate(Vector3.right * speed);
                        break;
                    case Direction.RotateLeft:
                        movetransform.Rotate(Vector3.up, speed);
                        break;
                    case Direction.RotateRight:
                        movetransform.Rotate(Vector3.up, -speed);
                        break;
                }
                yield return null;
            }
        }
    }
}



