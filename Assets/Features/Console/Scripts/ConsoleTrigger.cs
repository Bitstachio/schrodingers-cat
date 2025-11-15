using Features.Console.Interfaces;
using Features.Indicator.Scripts;
using UnityEngine;
using VContainer;

namespace Features.Console.Scripts
{
    public class ConsoleTrigger : MonoBehaviour
    {
        //===== Inspector Fields =====

        [SerializeField] private IndicatorImpl indicator;
        [SerializeField] private int consoleId;

        //===== Internal Fields =====

        private bool _playerInRange;

        //===== Dependency Injection =====

        private IConsoleService _consoleService;

        [Inject]
        public void Construct(IConsoleService consoleService)
        {
            _consoleService = consoleService;
        }

        //===== Lifecycle =====

        private void Update()
        {
            // TODO: Consider refactoring input handling to use input action
            if (_playerInRange && Input.GetKeyDown(KeyCode.E)) _consoleService.Open(consoleId);
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