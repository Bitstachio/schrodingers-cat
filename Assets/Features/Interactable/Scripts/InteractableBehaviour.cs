using Features.Interactable.Interfaces;
using Shared.Constants;
using Shared.Utils;
using UnityEngine;
using VContainer;

namespace Features.Interactable.Scripts
{
    public abstract class InteractableBehaviour<T> : MonoBehaviour, IInteractable
    {
        private bool _playerInRange;

        protected IInteractableService<T> InteractableService;

        [Inject]
        public void Construct(IInteractableService<T> interactableService) => InteractableService = interactableService;

        private void Awake() => ComponentValidationUtils.ValidateSingleTrigger(GetComponents<CircleCollider2D>());

        private void Update()
        {
            // TODO: Update control system
            if (!_playerInRange || !Input.GetKeyDown(KeyCode.E)) return;
            Interact();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Tags.Player)) _playerInRange = true;
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag(Tags.Player)) _playerInRange = false;
        }

        protected abstract void Interact();
    }
}