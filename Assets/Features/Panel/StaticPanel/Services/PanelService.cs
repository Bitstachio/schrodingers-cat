using System;
using Features.Panel.StaticPanel.Interfaces;
using Features.Panel.StaticPanel.Models;

namespace Features.Panel.StaticPanel.Services
{
    public class PanelService : IPanelService
    {
        //===== Events =====

        public event EventHandler<PanelInteractionEventArgs> Opened;

        //===== Actions =====

        public void Open(int panelId)
        {
            Opened?.Invoke(this, new PanelInteractionEventArgs(panelId));
        }
    }
}