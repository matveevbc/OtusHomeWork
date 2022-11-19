using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public sealed class AmmoEngine : MonoBehaviour
    {
        [SerializeField]
        private int ammoPoints;

        [SerializeField]
        private int ammoPointsMax;


        public bool TrySpendPoint()
        {
            if (ammoPoints > 0)
            {
                this.ammoPoints--;
                return true;
            }


            return false;
        }

        public bool IsFull()
        {
            return ammoPoints == ammoPointsMax;
        }


        public void Reload()
        {
            ammoPoints = ammoPointsMax;
        }
    }

}

