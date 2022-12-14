using Lessons.Architecture.GameContexts;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class ShootController : MonoBehaviour,
        IStartGameListener,
        IFinishGameListener,
        IConstructListener
    {
        private PlayerInput input;

        private IShootComponent shootComponent;


        public void Construct(GameContext context)
        {
            this.input = context.GetService<PlayerInput>();
            this.shootComponent = context.GetService<CharacterService>().
                GetCharacter().Get<IShootComponent>();
        }

        void IStartGameListener.OnStartGame()
        {
            this.input.OnJump += Shoot;
        }

        void IFinishGameListener.OnFinishGame()
        {
            this.input.OnJump -= Shoot;
        }

        private void Shoot()
        {
            shootComponent.Shoot();
        }
    }
}

