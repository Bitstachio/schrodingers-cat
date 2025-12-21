using Features.NPC.Cats.Shared.Enums;
using UnityEngine;

namespace Features.NPC.Cats.Shared.Scripts
{
    public class CatStateMachine : MonoBehaviour
    {
        public CatState Current { get; private set; } = CatState.Alive;
    }
}