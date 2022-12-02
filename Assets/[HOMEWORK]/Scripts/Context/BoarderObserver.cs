using System;
using Lessons.Architecture.GameContexts;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class BoarderObserver : MonoBehaviour, IConstructListener
    {
        private GameContext context;

        public static Action<Collider> OnTriggerEnter;

        public void Construct(GameContext _context)
        {
            Init(_context);
        }

        private void Init(GameContext _context)
        {
            context = _context;
            OnTriggerEnter += TriggerEnter;
        }

        private void EndGame()
        {
            context.FinishGame();
            OnTriggerEnter -= TriggerEnter;
        }

        private void TriggerEnter(Collider other)
        {
            EndGame();
        }

    }

}
