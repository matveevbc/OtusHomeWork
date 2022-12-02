using System;
using GameElements;
using Lessons.Architecture.MVA;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Lessons.Architecture.PresentationModel
{
    public sealed class UpgradeBuyer : MonoBehaviour, IGameInitElement
    {
        private MoneyStorage moneyStorage;

        [Button]
        public bool CanUpgrade(Upgrade upgrade)
        {
            return this.moneyStorage.Money >= upgrade.price;
        }

        [Button]
        public void Upgrade(Upgrade upgrade)
        {
            if (this.CanUpgrade(upgrade))
            {
                this.moneyStorage.SpendMoney(upgrade.price);
                Debug.Log($"<color=green>Product {upgrade.title} successfully upgraded!</color>");
            }
            else
            {
                Debug.LogWarning($"<color=red>Not enough money for {upgrade.title}!</color>");
            }
        }

        void IGameInitElement.InitGame(IGameContext context)
        {
            this.moneyStorage = context.GetService<MoneyStorage>();
        }
    }
}