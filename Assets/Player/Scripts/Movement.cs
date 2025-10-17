using UnityEngine;

namespace Player.Scripts
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 5f;
        
        private Rigidbody2D _rb;
        private Animator _animator;
        private Vector2 _movement;
        
        private static readonly int IsMoving = Animator.StringToHash("IsMoving");

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            _movement.x = Input.GetAxisRaw("Horizontal");
            _movement.y = Input.GetAxisRaw("Vertical");

            var isMoving = _movement.sqrMagnitude > 0;
            _animator.SetBool(IsMoving, isMoving);
        }

        private void FixedUpdate()
        {
            _rb.MovePosition(_rb.position + _movement * moveSpeed * Time.fixedDeltaTime);
        }
    }
}