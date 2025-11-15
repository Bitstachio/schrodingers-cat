using UnityEngine;

namespace Features.Player.Scripts
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 5f;

        private Rigidbody2D _rb;
        private Animator _animator;
        private Vector2 _movement;
        private SpriteRenderer _spriteRenderer;

        private static readonly int IsMoving = Animator.StringToHash("IsMoving");

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            _movement.x = Input.GetAxisRaw("Horizontal");
            _movement.y = Input.GetAxisRaw("Vertical");

            var isMoving = _movement.sqrMagnitude > 0;
            _animator.SetBool(IsMoving, isMoving);

            // Flip sprite depending on horizontal direction
            if (_movement.x != 0) _spriteRenderer.flipX = _movement.x < 0;
        }

        private void FixedUpdate()
        {
            // Normalize to prevent faster diagonal movement
            var normalizedMovement = _movement.normalized;

            _rb.MovePosition(_rb.position + normalizedMovement * moveSpeed * Time.fixedDeltaTime);
        }
    }
}