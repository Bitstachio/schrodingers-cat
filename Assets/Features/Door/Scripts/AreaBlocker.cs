using Shared.Constants;
using Shared.Utils;
using UnityEngine;

namespace Features.Door.Scripts
{
    [RequireComponent(typeof(CapsuleCollider2D))]
    public class AreaBlocker : MonoBehaviour
    {
        private void Awake() => ComponentValidationUtils.ValidateSingleTrigger(GetComponents<CapsuleCollider2D>());

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Tags.Player)) gameObject.SetActive(false);
        }
    }
}