using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Lessons.Architecture.PresentationModel
{
    public class UpgradePopup : Popup
    {
        [SerializeField]
        private TextMeshProUGUI titleText;

        [SerializeField]
        private TextMeshProUGUI nameText;

        [SerializeField]
        private TextMeshProUGUI descriptionText;

        [SerializeField]
        private TextMeshProUGUI lvlText;

        [SerializeField]
        private TextMeshProUGUI hpText;

        [SerializeField]
        private TextMeshProUGUI damageText;

        [SerializeField]
        private Image icon;

        [SerializeField]
        private UpgradeBtn upgradeBtn;

        private IPresentationModel presenter;

        protected override void OnShow(object args)
        {
            if (args is not IPresentationModel presenter)
            {
                throw new Exception("Expected Presentation model!");
            }
            
            this.presenter = presenter;
            this.presenter.OnUpgradeButtonStateChanged += this.OnUpgradeButtonStateChanged;
            this.presenter.Start();

            this.titleText.text = presenter.GetTitle();
            this.nameText.text = presenter.GetName();
            this.descriptionText.text = presenter.GetDescription();
            this.lvlText.text = presenter.GetLvl();
            this.hpText.text = presenter.GetHP();
            this.damageText.text = presenter.GetDamage();
            this.icon.sprite = presenter.GetIcon();

            this.upgradeBtn.SetPrice(presenter.GetPrice());
            this.upgradeBtn.SetAvailable(presenter.CanUpgrade());
            this.upgradeBtn.AddListener(this.OnUpgradeButtonClicked);
        }

        protected override void OnHide()
        {
            this.upgradeBtn.RemoveListener(this.OnUpgradeButtonClicked);
            this.presenter.OnUpgradeButtonStateChanged -= this.OnUpgradeButtonStateChanged;
            this.presenter.Stop();
        }

        private void OnUpgradeButtonStateChanged(bool isAvailabe)
        {
            this.upgradeBtn.SetAvailable(isAvailabe);
        }

        private void OnUpgradeButtonClicked()
        {
            this.presenter.OnUpgradeClicked();
        }

        public interface IPresentationModel
        {
            event Action<bool> OnUpgradeButtonStateChanged;

            void Start();

            void Stop();

            string GetTitle();

            string GetDescription();

            string GetName();

            string GetLvl();

            string GetHP();

            string GetDamage();

            Sprite GetIcon();

            string GetPrice();

            bool CanUpgrade();

            void OnUpgradeClicked();

        }
    }
}

