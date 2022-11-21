
using Lessons.Architecture.GameContexts;
using UnityEngine;


namespace Lessons.Architecture.Mechanics
{
    public class JumpController : MonoBehaviour,
        IStartGameListener,
        IFinishGameListener,
        IConstructListener
    {
        private InputController input;

        private IJumpComponent jumpComponent;


        public void Construct(GameContext context)
        {
            this.input = context.GetService<InputController>();
            this.jumpComponent = context.GetService<CharacterService>().
                GetCharacter().Get<IJumpComponent>();
        }

        void IStartGameListener.OnStartGame()
        {
            this.input.OnJump += Jump;
        }

        void IFinishGameListener.OnFinishGame()
        {
            this.input.OnJump-= Jump;
        }

        private void Jump()
        {
            jumpComponent.Jump();
        }
    }

}

