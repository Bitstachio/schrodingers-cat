using Features.Indicator.Scripts;
using Features.Panel.Interfaces;
using UnityEngine;
using UnityEngine.Serialization;
using VContainer;

namespace Features.Panel.Scripts
{
    public class PanelTrigger : MonoBehaviour
    {
        //===== Inspector Fields =====

        [SerializeField] private IndicatorImpl indicator;
        [SerializeField] private int panelId;

        //===== Internal Fields =====

        private bool _playerInRange;

        //===== Dependency Injection =====

        private IPanelService _panelService;

        [Inject]
        public void Construct(IPanelService panelService)
        {
            _panelService = panelService;
        }

        //===== Lifecycle =====

        private void Update()
        {
            // TODO: Consider refactoring input handling to use input action
            if (_playerInRange && Input.GetKeyDown(KeyCode.E)) _panelService.Open(panelId);
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