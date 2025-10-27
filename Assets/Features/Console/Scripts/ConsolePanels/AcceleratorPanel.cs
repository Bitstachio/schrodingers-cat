using Features.Console.Enums;
using Features.Console.Interfaces;
using UnityEngine;

namespace Features.Console.Scripts.ConsolePanels
{
    public class AcceleratorPanel : MonoBehaviour, IConsolePanel
    {
        public ConsoleType Type { get; } = ConsoleType.Accelerator;

        public void Show(int id)
        {
            Debug.Log($"Invoked... with {id}");
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}