using Elementary;
using UnityEngine;

namespace Lessons.Gameplay.Mech.Components
{
    public sealed class StoneLoadZoneComponent : MonoBehaviour, IStoneLoadZoneComponent
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
