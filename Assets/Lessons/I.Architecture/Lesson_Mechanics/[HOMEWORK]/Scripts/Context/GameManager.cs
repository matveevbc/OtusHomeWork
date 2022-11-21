using System;
using Lessons.Architecture.GameContexts;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public sealed class GameManager : MonoBehaviour,
        IConstructListener
    {
        [SerializeField]
        private TimerBehaviour countdown;

        private IMoveComponent moveComponent;

        private GameContext context;

        public static Action endGame;

        public void Construct(GameContext _context)
        {
            Init(_context);
        }

        private void Init(GameContext _context)
        {
            context = _context;
            countdown.OnEnded += StartGame;
            endGame += EndGame;
            countdown.Play();
            Debug.Log("Game will start at 3 sec...");
        }

        private void StartGame()
        {
            context.StartGame();
        }

        private void EndGame()
        {
            context.FinishGame();
        }
    }
}

