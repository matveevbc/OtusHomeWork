using System;
using Lessons.Architecture.GameContexts;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public sealed class GameManager : MonoBehaviour
    {
        [SerializeField]
        private TimerBehaviour countdown;

        private GameContext context;

        public static Action endGame;

        private void Start()
        {
            context = FindObjectOfType<GameContext>();
            context.ConstructGame();
            countdown.OnEnded += StartGame;
            endGame += EndGame;
            countdown.Play();
            Debug.Log("Game will start at 3 sec...");
        }

       
        private void StartGame()
        {
            countdown.OnEnded -= StartGame;
            context.StartGame();
        }

        private void EndGame()
        {
            context.FinishGame();
        }
    }
}

