using Shared.Constants;
using UnityEngine;

namespace Features.NPC.Cats.Shared.Scripts
{
    [RequireComponent(typeof(CircleCollider2D))]
    [RequireComponent(typeof(Animator))]
    public class CatEncounter : MonoBehaviour
    {
        private static readonly int PlayerInRange = Animator.StringToHash("PlayerInRange");

        private Animator _animator;
        private Transform _player;

        private void Awake() => _animator = GetComponent<Animator>();

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.CompareTag(Tags.Player)) return;

            _player = other.transform;
            _animator.SetBool(PlayerInRange, true);

            FacePlayer();
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (!other.CompareTag(Tags.Player)) return;

            _animator.SetBool(PlayerInRange, false);
            _player = null;
        }

        private void Update()
        {
            if (_player != null) FacePlayer();
        }

        private void FacePlayer()
        {
            var direction = _player.position.x - transform.position.x;
            if (Mathf.Approximately(direction, 0f)) return;

            var scale = transform.localScale;
            scale.x = Mathf.Sign(direction) * Mathf.Abs(scale.x);
            transform.localScale = scale;
        }
    }
}