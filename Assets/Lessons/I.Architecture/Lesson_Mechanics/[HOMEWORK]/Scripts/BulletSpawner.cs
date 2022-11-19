using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class BulletSpawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject prefab;

        [SerializeField]
        private Transform conteiner;

        public void Spawn()
        {
            GameObject go = Instantiate(prefab, conteiner);
        }
    }
}

