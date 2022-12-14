using System;
using Elementary;
using UnityEngine;

namespace Lessons.Gameplay.Mech
{
    public sealed class ConveyorZoneVisualAdapter : MonoBehaviour
    {
        [SerializeField]
        private ConveyorZoneVisual view;

        [SerializeField]
        private IntBehaviourLimited inputStorage;

        private void OnEnable()
        {
            this.view.SetupItems(this.inputStorage.Value);
            this.inputStorage.OnValueChanged += this.view.SetupItems;
        }

        private void OnDisable()
        {
            this.inputStorage.OnValueChanged -= this.view.SetupItems;
        }

        private void OnValidate()
        {
            if (this.view != null && this.inputStorage != null)
            {
                this.inputStorage.OnValueChanged -= this.view.SetupItems;
                this.inputStorage.OnValueChanged += this.view.SetupItems;
            }
        }
    }
}