using Features.Console.Enums;
using Features.Console.Interfaces;
using UnityEngine;

namespace Features.Console.Scripts.ConsolePanels
{
    public class ColliderPanel : MonoBehaviour, IConsolePanel
    {
        [SerializeField] private int id;

        public int Id => id;
        public ConsoleType Type { get; } =  ConsoleType.Collider;
        
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