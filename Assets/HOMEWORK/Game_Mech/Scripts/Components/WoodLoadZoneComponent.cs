using Elementary;
using UnityEngine;

namespace Lessons.Gameplay.Mech.Components
{
    public sealed class WoodLoadZoneComponent : MonoBehaviour, IWoodLoadZoneComponent
    {
        [SerializeField]
        private IntBehaviourLimited loadStorage;

        public bool CanLoad()
        {
            return !this.loadStorage.IsLimit;
        }

        public void Load(int resources)
        {
            this.loadStorage.Value += resources;
        }
    }

}