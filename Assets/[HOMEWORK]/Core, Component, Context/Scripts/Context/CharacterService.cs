using Lessons.Architecture.Mechanics;
using UnityEngine;

namespace Lessons.Architecture.GameContexts
{
    public class CharacterService : MonoBehaviour
    {
        [SerializeField]
        private Entity character;

        public IEntity GetCharacter()
        {
            return this.character;
        }
    }
}