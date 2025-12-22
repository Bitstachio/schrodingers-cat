using UnityEngine;

namespace Features.Door.Scripts
{
    // TODO: I'm absolutely not in the mood to fix this
    // When game starts, this door needs to be closed
    // I'm not in the mood to deal with the BS of sharing 1 animator with 2 objects with different initial states
    public class TempDoor : MonoBehaviour
    {
        [SerializeField] private DoorBehaviour door;

        private void Start() => door.Close();
    }
}