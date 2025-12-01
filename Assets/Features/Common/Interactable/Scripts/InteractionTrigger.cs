using Features.Common.Interactable.Interfaces;
using Features.Indicator.Scripts;
using UnityEngine;

namespace Features.Common.Interactable.Scripts
{
    public class InteractionTrigger : MonoBehaviour
    {
        [SerializeField] private IndicatorImpl indicator;

        private Transform _root;
        private IInteractable[] _interactables;
        private bool _playerInRange;

        //===== Lifecycle =====

        private void Awake()
        {
            _root = transform.parent != null ? transform.parent : transform;
            _interactables = _root.GetComponentsInChildren<IInteractable>(true);
        }

        private void Update()
        {
            // TODO: Update control system
            if (!_playerInRange || !Input.GetKeyDown(KeyCode.E)) return;
            foreach (var interactable in _interactables) interactable.Interact();
        }

        //===== Trigger Events =====

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.CompareTag("Player")) return;
            _playerInRange = true;
            indicator.Show();
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (!other.CompareTag("Player")) return;
            _playerInRange = false;
            indicator.Hide();
        }
    }
}