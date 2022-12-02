using GameElements;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Lessons.Architecture.PresentationModel
{
    public class UpgradeShower : MonoBehaviour, IGameInitElement
    {
        private PopupManager popupManager;

        private UpgradePresentationModelFactory presenterFactory;

        [Button]
        public void ShowUpgrade(Upgrade upgrade)
        {
            var presentationModel = this.presenterFactory.CreatePresenter(upgrade);
            this.popupManager.ShowPopup(PopupName.UPGRADE, presentationModel);
        }

        void IGameInitElement.InitGame(IGameContext context)
        {
            this.popupManager = context.GetService<PopupManager>();
            this.presenterFactory = context.GetService<UpgradePresentationModelFactory>();
        }
    }

}
