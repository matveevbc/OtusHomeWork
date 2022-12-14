using Entities;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Lessons.Gameplay.Mech
{
    public sealed class ConveyorTest : MonoBehaviour
    {
        [SerializeField]
        private UnityEntity conveyor;

        [Button]
        private void LoadWood(int resourceCount)
        {
            var loadComponent = this.conveyor.Get<IWoodLoadZoneComponent>();
            if (loadComponent.CanLoad())
            {
                loadComponent.Load(resourceCount);
            }
        }

        [Button]
        private void LoadStone(int resourceCount)
        {
            var loadComponent = this.conveyor.Get<IStoneLoadZoneComponent>();
            if (loadComponent.CanLoad())
            {
                loadComponent.Load(resourceCount);
            }
        }


        [Button]
        private void TakeAllResources()
        {
            var unloadComponent = this.conveyor.Get<IUnloadZoneComponent>();
            if (unloadComponent.CanUnload())
            {
                var extractedResources = unloadComponent.UnloadAll();
                Debug.Log($"Extracted resources {extractedResources}");
            }
        }
    }
}