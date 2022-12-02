using GameElements;
using UnityEngine;

namespace Lessons.Architecture.MVA
{
    //ADAPTER
    public sealed class MoneyPanelAdapter : MonoBehaviour, 
        IGameInitElement,
        IGameReadyElement,
        IGameFinishElement
    {
        [SerializeField]
        private CurrencyPanel moneyPanel;

        private MoneyStorage moneyStorage;

        void IGameInitElement.InitGame(IGameContext context)
        {
            this.moneyStorage = context.GetService<MoneyStorage>();
            this.moneyPanel.SetupMoney(this.moneyStorage.Money.ToString());
        }

        void IGameReadyElement.ReadyGame(IGameContext context)
        {
            this.moneyStorage.OnMoneyChanged += this.OnMoneyChanged;
        }

        void IGameFinishElement.FinishGame(IGameContext context)
        {
            this.moneyStorage.OnMoneyChanged -= this.OnMoneyChanged;
        }

        private void OnMoneyChanged(BigNumber money)
        {
            this.moneyPanel.UpdateMoney(money.ToString());
        }
    }
}