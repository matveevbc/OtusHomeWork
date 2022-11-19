using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class MoveMechanic : MonoBehaviour
    {

        [SerializeField]
        private MoveEngine move;

        [SerializeField]
        private EventReceiver startReceiver;


        [SerializeField]
        private EventReceiver stopReceiver;

        private void OnEnable()
        {
            this.startReceiver.OnEvent += this.Move;
            this.stopReceiver.OnEvent += this.Stop;
        }

        private void OnDisable()
        {
            this.startReceiver.OnEvent -= this.Move;
            this.stopReceiver.OnEvent -= this.Stop;
        }

        private void Move()
        {
            move.Play();
        }

        private void Stop()
        {
            move.Stop();
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