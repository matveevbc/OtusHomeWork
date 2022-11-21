using System;
using Lessons.Architecture.GameContexts;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class BoarderBehavior : MonoBehaviour, IConstructListener
    {
        private GameContext context;

        public void Construct(GameContext _context)
        {
            Init(_context);
        }

        private void Init(GameContext _context)
        {
            context = _context;
        }

        private void EndGame()
        {
            context.FinishGame();
        }

        private void OnTriggerEnter(Collider other)
        {
            EndGame();
        }

    }

}
