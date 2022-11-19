using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class ShootController : MonoBehaviour
    {
        [SerializeField]
        private Entity unit;

        private void Update()
        {
            this.HandleKeyboard();
        }

        private void HandleKeyboard()
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                this.Shoot();
            }
        }

        private void Shoot()
        {
            unit.Get<ShootComponent>().Shoot();
        }
    }
}

