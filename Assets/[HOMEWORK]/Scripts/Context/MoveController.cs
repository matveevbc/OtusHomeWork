using Lessons.Architecture.GameContexts;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class MoveController : MonoBehaviour,
        IStartGameListener,
        IFinishGameListener,
        IConstructListener
    {
        private PlayerInput input;

        private IMoveComponent moveComponent;


        public void Construct(GameContext context)
        {
            this.input = context.GetService<PlayerInput>();
            this.moveComponent = context.GetService<CharacterService>().
                GetCharacter(). Get<IMoveComponent>();
        }

        void IStartGameListener.OnStartGame()
        {
            this.input.OnMove += OnMove;
        }

        void IFinishGameListener.OnFinishGame()
        {
            this.input.OnMove  -= OnMove;
        }

        private void OnMove(Direction dir)
        {
            this.moveComponent.Move(dir);
        }

    }
}

