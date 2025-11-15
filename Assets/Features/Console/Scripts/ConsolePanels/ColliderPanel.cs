using Features.Console.Enums;
using Features.Console.Interfaces;
using UnityEngine;

namespace Features.Console.Scripts.ConsolePanels
{
    public class ColliderPanel : MonoBehaviour, IConsolePanel
    {
        [SerializeField] private int consoleId;

        public int ConsoleId => consoleId;
        public ConsoleType ConsoleType { get; } =  ConsoleType.Collider;
        
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