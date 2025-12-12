using Shared.Scripts;
using Shared.Utils;
using UnityEngine;

namespace Features.Indicator.Scripts
{
    [RequireComponent(typeof(CircleCollider2D))]
    public class IndicatorTarget : MonoBehaviour
    {
        [SerializeField] private Indicator indicator;

        //===== Lifecycle =====

        private void Awake()
        {
            var colliders = GetComponents<CircleCollider2D>();
            ComponentValidationUtils.ValidateSingleTrigger(colliders);
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