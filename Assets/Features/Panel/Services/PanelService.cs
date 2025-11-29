using System;
using Features.Panel.Interfaces;
using Features.Panel.Models;

namespace Features.Panel.Services
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