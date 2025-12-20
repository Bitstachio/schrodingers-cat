using Features.Door.Interfaces;
using UnityEngine;
using VContainer;

namespace Features.Door.Scripts
{
    [RequireComponent(typeof(BoxCollider2D), typeof(Animator))]
    public class DoorBehaviour : MonoBehaviour, IDoor
    {
        private static readonly int OpenDoor = Animator.StringToHash("OpenDoor");
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

        public void Open()
        {
            _animator.SetTrigger(OpenDoor);
            _boxCollider.enabled = false;
            _doorService.Open();
        }

        public void Close()
        {
            _animator.SetTrigger(CloseDoor);
            _boxCollider.enabled = true;
            _doorService.Close();
        }
    }
}