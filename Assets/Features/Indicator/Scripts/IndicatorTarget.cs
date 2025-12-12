using Shared.Exceptions;
using Shared.Scripts;
using UnityEngine;

namespace Features.Indicator.Scripts
{
    [RequireComponent(typeof(CircleCollider2D))]
    public class IndicatorTarget : MonoBehaviour
    {
        [SerializeField] private Indicator indicator;

        private const int NumColliders = 1;

        //===== Lifecycle =====

        private void Awake()
        {
            // Validate that exactly 1 circle collider exists and is set as a trigger
            var colliders = GetComponents<CircleCollider2D>();
            if (colliders.Length > NumColliders)
                throw new TooManyComponentsException(typeof(CircleCollider2D), NumColliders, colliders.Length);
            if (!colliders[0].isTrigger) throw new ColliderNotTriggerException();
        }

        //===== Trigger Events =====

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Tags.Player)) indicator.Show();
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag(Tags.Player)) indicator.Hide();
        }
    }
}