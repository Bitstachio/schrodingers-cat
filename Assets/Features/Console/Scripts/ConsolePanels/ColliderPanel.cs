using Features.Console.Enums;
using Features.Console.Interfaces;
using UnityEngine;

namespace Features.Console.Scripts.ConsolePanels
{
    public class ColliderPanel : MonoBehaviour, IConsolePanel
    {
        public ConsoleType Type { get; } =  ConsoleType.Collider;
        
        public void Show(int id)
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}