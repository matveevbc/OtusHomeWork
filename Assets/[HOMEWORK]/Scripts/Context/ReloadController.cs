using Lessons.Architecture.GameContexts;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class ReloadController : MonoBehaviour,
        IStartGameListener,
        IFinishGameListener,
        IConstructListener
    {
        private PlayerInput input;

        private IReloadComponent reloadComponent;


        public void Construct(GameContext context)
        {
            this.input = context.GetService<PlayerInput>();
            this.reloadComponent = context.GetService<CharacterService>().
                GetCharacter().Get<IReloadComponent>();
        }

        void IStartGameListener.OnStartGame()
        {
            this.input.OnJump += Reload;
        }

        void IFinishGameListener.OnFinishGame()
        {
            this.input.OnJump -= Reload;
        }
        private void Reload()
        {
            reloadComponent.Reload();
        }
    }
}

