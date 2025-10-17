using UnityEngine;

namespace Player.Scripts
{
    public class Movement : MonoBehaviour
    {
        [Header("Movement Settings")] [SerializeField]
        private float moveSpeed = 5f;

        private Rigidbody2D _rb;
        private Vector2 _movement;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            // Process input
            _movement.x = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right
            _movement.y = Input.GetAxisRaw("Vertical"); // W/S or Up/Down
        }

        private void FixedUpdate()
        {
            _rb.MovePosition(_rb.position + _movement * moveSpeed * Time.fixedDeltaTime);
        }

        // Optional: method to access movement for animations
        public Vector2 GetMovementDirection()
        {
            return _movement;
        }
    }
}