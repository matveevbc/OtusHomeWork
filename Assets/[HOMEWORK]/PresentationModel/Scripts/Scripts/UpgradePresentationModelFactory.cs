using GameElements;
using Lessons.Architecture.MVA;
using UnityEngine;

namespace Lessons.Architecture.PresentationModel
{
    public sealed class UpgradePresentationModelFactory : MonoBehaviour, IGameInitElement
    {
        private UpgradeBuyer upgradeBuyer;

        private MoneyStorage moneyStorage;

        public UpgradePresentationModel CreatePresenter(Upgrade upgrade)
        {
            return new UpgradePresentationModel(upgrade, this.upgradeBuyer, this.moneyStorage);
        }

        void IGameInitElement.InitGame(IGameContext context)
        {
            this.upgradeBuyer = context.GetService<UpgradeBuyer>();
            this.moneyStorage = context.GetService<MoneyStorage>();
        }
    }
}