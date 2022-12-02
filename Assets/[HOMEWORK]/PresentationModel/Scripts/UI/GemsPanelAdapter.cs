using GameElements;
using UnityEngine;

namespace Lessons.Architecture.MVA
{
    public sealed class GemsPanelAdapter : MonoBehaviour,
        IGameInitElement,
        IGameReadyElement,
        IGameFinishElement
    {
        [SerializeField]
        private CurrencyPanel gemsPanel;

        private GemsStorage gemsStorage;

        void IGameInitElement.InitGame(IGameContext context)
        {
            this.gemsStorage = context.GetService<GemsStorage>();
            this.gemsPanel.SetupMoney(this.gemsStorage.Gems.ToString());
        }

        void IGameReadyElement.ReadyGame(IGameContext context)
        {
            this.gemsStorage.OnGemsChanged += this.OnGemsChanged;
        }

        void IGameFinishElement.FinishGame(IGameContext context)
        {
            this.gemsStorage.OnGemsChanged -= this.OnGemsChanged;
        }

        private void OnGemsChanged(int gems)
        {
            this.gemsPanel.UpdateMoney(gems.ToString());
        }
    }
}