using System;
using Lessons.Architecture.MVA;
using UnityEngine;

namespace Lessons.Architecture.PresentationModel
{
    public sealed class UpgradePresentationModel : UpgradePopup.IPresentationModel
    {
        public event Action<bool> OnUpgradeButtonStateChanged;

        private readonly Upgrade upgrade;

        private readonly UpgradeBuyer upgradeBuyer;

        private readonly MoneyStorage moneyStorage;

        public UpgradePresentationModel(Upgrade upgrade, UpgradeBuyer upgradeBuyer, MoneyStorage moneyStorage)
        {
            this.upgrade = upgrade;
            this.upgradeBuyer = upgradeBuyer;
            this.moneyStorage = moneyStorage;
        }


        public void Start()
        {
            this.moneyStorage.OnMoneyChanged += this.OnMoneyChanged;
        }

        public void Stop()
        {
            this.moneyStorage.OnMoneyChanged -= this.OnMoneyChanged;
        }

        public string GetTitle()
        {
            return this.upgrade.title;
        }

        public string GetDescription()
        {
            return this.upgrade.description;
        }

        public string GetName()
        {
            return this.upgrade.upgradeName;
        }

        public string GetLvl()
        {
            return "Level: " + this.upgrade.lvl;
        }

        public string GetHP()
        {
            return "HP: " + this.upgrade.hp;
        }

        public string GetDamage()
        {
            return "Damage: " + this.upgrade.damage;
        }

        public Sprite GetIcon()
        {
            return this.upgrade.icon;
        }

        public string GetPrice()
        {
            return this.upgrade.price.ToString();
        }

        public bool CanUpgrade()
        {
            return this.upgradeBuyer.CanUpgrade(this.upgrade);
        }

        public void OnUpgradeClicked()
        {
            this.upgradeBuyer.Upgrade(this.upgrade);
        }

        private void OnMoneyChanged(BigNumber money)
        {
            var canUpgrade = this.upgradeBuyer.CanUpgrade(this.upgrade);
            this.OnUpgradeButtonStateChanged?.Invoke(canUpgrade);
        }

    }
}