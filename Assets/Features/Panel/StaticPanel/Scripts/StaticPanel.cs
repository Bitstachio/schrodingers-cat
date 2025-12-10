using Features.Panel.Common.Exceptions;
using Features.Panel.Common.Interfaces;
using UnityEngine;

namespace Features.Panel.StaticPanel.Scripts
{
    public class StaticPanel : MonoBehaviour, IPanel<int>
    {
        [SerializeField] private int id;

        public int Id => id;

        //===== Interface Implementation =====

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