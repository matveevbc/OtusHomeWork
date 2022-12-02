
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class MoveMechanic : MonoBehaviour
    {
        [SerializeField]
        private Transform movetransform;

        [SerializeField]
        private DirectionEventReciever startReceiver;


        private void OnEnable()
        {
            this.startReceiver.OnEvent += this.Move;
        }

        private void OnDisable()
        {
            this.startReceiver.OnEvent -= this.Move;
        }

        private void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.Forward:
                    movetransform.Translate(Vector3.forward * Time.deltaTime * 2);
                    break;
                case Direction.Backward:
                    movetransform.Translate(Vector3.back * Time.deltaTime * 2);
                    break;
                case Direction.LeftStep:
                    movetransform.Translate(Vector3.left * Time.deltaTime * 2);
                    break;
                case Direction.RightStep:
                    movetransform.Translate(Vector3.right * Time.deltaTime * 2);
                    break;
                case Direction.RotateLeft:
                    movetransform.Rotate(Vector3.up, Time.deltaTime * 30);
                    break;
                case Direction.RotateRight:
                    movetransform.Rotate(Vector3.up, -Time.deltaTime * 30);
                    break;
            }
        }
    }



    public enum Direction
    {
        LeftStep,
        RightStep,
        Forward,
        Backward,
        RotateLeft,
        RotateRight
    }
}