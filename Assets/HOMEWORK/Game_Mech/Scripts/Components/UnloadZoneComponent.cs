using Elementary;
using UnityEngine;

namespace Lessons.Gameplay.Mech
{
    public class UnloadZoneComponent : MonoBehaviour, IUnloadZoneComponent
    {
        [SerializeField]
        private IntBehaviourLimited unloadStorage;

        public bool CanUnload()
        {
            return this.unloadStorage.Value > 0;
        }

        public int UnloadAll()
        {
            var result = this.unloadStorage.Value;
            this.unloadStorage.Value = 0;
            return result;
        }
    }
}