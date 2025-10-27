using Features.Console.Interfaces;
using UnityEngine;

namespace Features.Console.Scripts.ConsolePanels
{
    public class ColliderPanel : MonoBehaviour, IConsolePanel
    {
        public void Show(int id)
        {
            Debug.Log("Collider console is launched");
            Debug.Log(id);
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}