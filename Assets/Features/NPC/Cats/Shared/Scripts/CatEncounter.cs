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

        private void Awake() => _animator = GetComponent<Animator>();

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Tags.Player)) _animator.SetBool(PlayerInRange, true);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag(Tags.Player)) _animator.SetBool(PlayerInRange, false);
        }
    }
}