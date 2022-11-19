using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class ReloadController : MonoBehaviour
    {
        [SerializeField]
        private Entity unit;

        private void Update()
        {
            this.HandleKeyboard();
        }

        private void HandleKeyboard()
        {
            if (Input.GetKey(KeyCode.R))
            {
                this.Reload();
            }
        }

        private void Reload()
        {
            unit.Get<ReloadComponent>().Reload();
        }
    }
}

