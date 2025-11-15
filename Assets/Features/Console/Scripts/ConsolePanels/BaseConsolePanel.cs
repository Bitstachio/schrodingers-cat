using Features.Console.Exceptions;
using Features.Console.Interfaces;
using UnityEngine;

namespace Features.Console.Scripts.ConsolePanels
{
    public abstract class BaseConsolePanel : MonoBehaviour, IConsolePanel
    {
        [SerializeField] private int id;

        public int Id => id;

        public void Show(int consoleId)
        {
            if (gameObject.activeSelf) throw new ConsoleAlreadyOpenException();
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            if (!gameObject.activeSelf) throw new ConsoleNotOpenException();
            gameObject.SetActive(false);
        }
    }
}