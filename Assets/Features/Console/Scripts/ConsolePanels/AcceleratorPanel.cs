using Features.Console.Enums;
using Features.Console.Interfaces;
using UnityEngine;

namespace Features.Console.Scripts.ConsolePanels
{
    public class AcceleratorPanel : MonoBehaviour, IConsolePanel
    {
        public ConsoleType ConsoleType { get; } = ConsoleType.Accelerator;

        public void Show(int consoleId)
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}