using System;
using Lessons.Architecture.GameContexts;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public sealed class PlayerInput: MonoBehaviour,
        IStartGameListener,
        IPauseGameListener,
        IResumeGameListener,
        IFinishGameListener
    {
        public event Action<Direction> OnMove;
        public event Action OnJump;
        public event Action OnShoot;
        public event Action OnReload;

        private void Awake()
        {
            this.enabled = false;
        }

        void IStartGameListener.OnStartGame()
        {
            this.enabled = true;
        }

        void IFinishGameListener.OnFinishGame()
        {
            this.enabled = false;
        }

        void IPauseGameListener.OnPauseGame()
        {
            this.enabled = false;
        }

        void IResumeGameListener.OnResumeGame()
        {
            this.enabled = true;
        }

        private void Update()
        {
            this.HandleKeyboard();
        }

        private void HandleKeyboard()
        {
          //  this.Move(Direction.Forward);
            if (Input.GetKey(KeyCode.W))
            {
                this.Move(Direction.Forward);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                this.Move(Direction.Backward);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                this.Move(Direction.LeftStep);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                this.Move(Direction.RightStep);
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                this.Move(Direction.RotateLeft);
            }
            else if (Input.GetKey(KeyCode.E))
            {
                this.Move(Direction.RotateRight);
            }
            else if (Input.GetKey(KeyCode.Space))
            {
                this.Jump();
            }
            else if (Input.GetKey(KeyCode.Mouse0))
            {
                this.Shoot();
            }
            else if (Input.GetKey(KeyCode.R))
            {
                this.Shoot();
            }
        }

        private void Move(Direction dir)
        {
            this.OnMove?.Invoke(dir);
        }

        private void Jump()
        {
            this.OnJump?.Invoke();
        }

        private void Shoot()
        {
            this.OnShoot?.Invoke();
        }

        private void Reload()
        {
            this.OnReload?.Invoke();
        }

    }

}

