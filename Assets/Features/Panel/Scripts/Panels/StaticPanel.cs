using Features.Panel.Exceptions;
using Features.Panel.Interfaces;
using Shared.EventBus.Implementation;
using Shared.EventBus.Structs;
using UnityEngine;

namespace Features.Panel.Scripts.Panels
{
    public class StaticPanel : EventListenerBehaviour<PuzzleAttemptEventArgs>, IPanel<int>
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

        protected override void OnInvoked(PuzzleAttemptEventArgs e)
        {
            if (e.Result) Hide();
        }
    }
}