using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{

    public class MoveMechanicks : MonoBehaviour
    {
        public Vector3 Direction
        {
            get { return this.direction; }
        }
        [PropertyOrder(-8)]
        [ReadOnly]
        [ShowInInspector]
        private Vector3 direction;


        [SerializeField]
        private Vector3EventReciever startReciveir;

        [SerializeField]
        private EventReceiver stopReceiver;

        [SerializeField]
        private Transform playerTransform;

        private bool isMove;

        private Vector3 vector3;

        // Update is called once per frame
        void Update()
        {
            if (isMove)
            {
                playerTransform.Translate(direction );
            }
        }

        private void OnEnable()
        {
            this.startReciveir.OnEvent += this.StartMove;
            this.stopReceiver.OnEvent += this.StopMove;
        }

        private void OnDisable()
        {
            this.startReciveir.OnEvent -= this.StartMove;
            this.stopReceiver.OnEvent -= this.StopMove;
        }

        public void StartMove(Vector3 _direction)
        {
            direction = _direction;
            isMove = true;
        }

        public void StopMove()
        {
            isMove = false;
        }
    }

}
