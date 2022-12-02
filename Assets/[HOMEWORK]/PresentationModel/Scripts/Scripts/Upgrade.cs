using Sirenix.OdinInspector;
using UnityEngine;

namespace Lessons.Architecture.PresentationModel
{
    [CreateAssetMenu(
        fileName = "Upgrade",
        menuName = "MVP/Homework"
    )]

    public sealed class Upgrade : ScriptableObject
    {
        [PreviewField]
        [SerializeField]
        public Sprite icon;

        [SerializeField]
        public string title;

        [SerializeField]
        public string upgradeName;

        [TextArea]
        [SerializeField]
        public string description;

        [SerializeField]
        public string lvl;

        [SerializeField]
        public string hp;

        [SerializeField]
        public string damage;

        [Space]
        [SerializeField]
        public BigNumber price;
    }

}