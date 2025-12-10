using Features.Panel.Common.Exceptions;
using Features.Panel.StaticPanel.Interfaces;
using UnityEngine;

namespace Features.Panel.StaticPanel.Scripts
{
    public class StaticPanel : MonoBehaviour, IPanel
    {
        [SerializeField] private int id;

        public int Id => id;

        public void Show(int panelId)
        {
            if (gameObject.activeSelf) throw new PanelAlreadyOpenException();
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            if (!gameObject.activeSelf) throw new PanelNotOpenException();
            gameObject.SetActive(false);
        }
    }
}