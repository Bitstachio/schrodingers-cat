using Shared.Constants;
using UnityEngine;

namespace Features.Door.Scripts
{
    [RequireComponent(typeof(BoxCollider2D), typeof(CapsuleCollider2D), typeof(Animator))]
    public class DoorController : MonoBehaviour
    {
        private static readonly int CloseDoor = Animator.StringToHash("CloseDoor");
        
        private BoxCollider2D _boxCollider;
        private CapsuleCollider2D _capsuleCollider;
        private Animator _animator;

        private void Awake()
        {
            _boxCollider = GetComponent<BoxCollider2D>();
            _capsuleCollider = GetComponent<CapsuleCollider2D>();
            _animator = GetComponent<Animator>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Tags.Player)) Close();
        }

        private void Close()
        {
            _animator.SetTrigger(CloseDoor);
            _boxCollider.enabled = true;
        }
    }
}