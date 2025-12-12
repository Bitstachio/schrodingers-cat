using Features.Common.Interactable.Interfaces;
using Shared.Scripts;
using UnityEngine;

namespace Features.Common.Interactable.Scripts
{
    public class InteractionTrigger : MonoBehaviour
    {
        private IInteractable[] _interactables;
        private bool _playerInRange;

        //===== Lifecycle =====

        private void Awake()
        {
            _interactables = GetComponentsInChildren<IInteractable>(true);
        }

        private void Update()
        {
            // TODO: Update control system
            if (!_playerInRange || !Input.GetKeyDown(KeyCode.E)) return;
            foreach (var interactable in _interactables)
            {
                if (((MonoBehaviour)interactable).isActiveAndEnabled) interactable.Interact();
            }
        }

        //===== Trigger Events =====

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Tags.Player)) _playerInRange = true;
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag(Tags.Player)) _playerInRange = false;
        }
    }
}