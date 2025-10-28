using System.Linq;
using Features.Console.Interfaces;
using Features.Console.Models;
using UnityEngine;
using VContainer;

namespace Features.Console.Scripts
{
    public class ConsolePanelDispatcher : MonoBehaviour
    {
        //===== Internal Fields =====

        private IConsolePanel[] _panels;

        //===== Dependency Injection =====

        private IConsoleService _consoleService;

        [Inject]
        public void Construct(IConsoleService consoleService)
        {
            _consoleService = consoleService;
        }

        //===== Lifecycle =====

        private void Awake()
        {
            _panels = GetComponentsInChildren<MonoBehaviour>(true)
                .OfType<IConsolePanel>()
                .ToArray();
        }

        // Handle subscription to console service

        private void OnEnable()
        {
            _consoleService.Opened += OnConsoleOpened;
        }

        private void OnDisable()
        {
            _consoleService.Opened -= OnConsoleOpened;
        }

        //===== Event Handlers =====

        private void OnConsoleOpened(object sender, ConsoleInteractionEventArgs e)
        {
            foreach (var panel in _panels)
            {
                if (panel.ConsoleType == e.ConsoleType) panel.Show(e.ConsoleId);
            }
        }
    }
}