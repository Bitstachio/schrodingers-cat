using Features.Door.Interfaces;
using Shared.Constants;
using UnityEngine;
using VContainer;

namespace Features.Door.Scripts
{
    [RequireComponent(typeof(BoxCollider2D), typeof(CapsuleCollider2D), typeof(Animator))]
    public class Door : MonoBehaviour, IDoor
    {
        private static readonly int CloseDoor = Animator.StringToHash("CloseDoor");

        private IDoorService _doorService;
        private BoxCollider2D _boxCollider;
        private Animator _animator;

        [Inject]
        public void Construct(IDoorService doorService) => _doorService = doorService;

        private void Awake()
        {
            _boxCollider = GetComponent<BoxCollider2D>();
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
            _doorService.Close();
        }
    }
}