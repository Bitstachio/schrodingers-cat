using Features.Console.Interfaces;
using UnityEngine;

namespace Features.Console.Scripts.ConsolePanels
{
    public class AcceleratorPanel : MonoBehaviour, IConsolePanel
    {
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