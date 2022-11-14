using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class Spawner : MonoBehaviour
    {
        public void Spawn(GameObject prefab, Transform spawnPoin)
        {
            GameObject go = Instantiate(prefab, spawnPoin);
        }
    }
}

