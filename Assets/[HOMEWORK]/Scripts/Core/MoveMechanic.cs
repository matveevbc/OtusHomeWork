
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class MoveMechanic : MonoBehaviour
    {
        [SerializeField]
        private Transform[] movetransform;

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
            Vector3 _dir = new Vector3();
            switch (dir)
            {
                case Direction.Forward:
                    _dir = Vector3.forward;
                    break;
                case Direction.Backward:
                    _dir =Vector3.forward;
                    break;
                case Direction.LeftStep:
                    _dir = Vector3.left;
                    break;
                case Direction.RightStep:
                    _dir = Vector3.right;
                    break;
                case Direction.RotateLeft:
                    _dir = Vector3.up;
                    break;
                case Direction.RotateRight:
                    _dir = Vector3.up;
                    break;
            }

            foreach (var a in movetransform) a.Translate(_dir * Time.deltaTime * 2);
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