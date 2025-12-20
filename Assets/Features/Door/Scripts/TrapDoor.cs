using Shared.Constants;
using UnityEngine;

namespace Features.Door.Scripts
{
    [RequireComponent(typeof(CapsuleCollider2D))]
    public class TrapDoor : DoorBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Tags.Player)) Close();
        }
    }
}