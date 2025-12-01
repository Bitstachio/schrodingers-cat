using System;
using Features.Panel.StaticPanel.Interfaces;
using Features.Panel.StaticPanel.Models;

namespace Features.Panel.StaticPanel.Services
{
    public class StaticPanelService : IPanelService
    {
        //===== Events =====

        public event EventHandler<StaticPanelInteractionEventArgs> Opened;

        //===== Actions =====

        public void Open(int panelId)
        {
            Opened?.Invoke(this, new StaticPanelInteractionEventArgs(panelId));
        }
    }
}