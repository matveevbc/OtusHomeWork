using System;
using Lessons.Architecture.GameContexts;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class BoarderObserver : MonoBehaviour,
        IStartGameListener,
        IFinishGameListener,
        IConstructListener
    {
        private GameContext context;

        private ITriggerComponent triggerComponent;

        public void Construct(GameContext _context)
        {
            Init(_context);
        }

        private void Init(GameContext _context)
        {
            context = _context;
            triggerComponent = context.GetService<CharacterService>().
                GetCharacter().Get<ITriggerComponent>();
        }

        void IStartGameListener.OnStartGame()
        {
            this.triggerComponent.OnTrigger += TriggerEnter;
        }

        void IFinishGameListener.OnFinishGame()
        {
            this.triggerComponent.OnTrigger -= TriggerEnter;
        }

        private void TriggerEnter(Collider other)
        {
            if(other.tag == "Finish")
            {
                context.FinishGame();
            }
        }
    }
}
