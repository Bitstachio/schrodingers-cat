using Features.Console.Exceptions;
using Features.Console.Interfaces;
using UnityEngine;

namespace Features.Console.Scripts.ConsolePanels
{
    public class AcceleratorPanel : MonoBehaviour, IConsolePanel
    {
        [SerializeField] private int consoleId;

        public int Id => consoleId;

        //===== Internal Fields =====

        private int? _consoleId; 

        public void Show(int consoleId)
        {
            _consoleId = consoleId;
            gameObject.SetActive(true);
            // TODO: Load data corresponding to console ID
        }

        public void Hide()
        {
            // TODO: Determine if this is the appropriate exception class in this scope 
            if (!_consoleId.HasValue) throw new ConsoleNotOpenException();
            gameObject.SetActive(false);
            // TODO: Save data corresponding to console ID 
        }
    }
}