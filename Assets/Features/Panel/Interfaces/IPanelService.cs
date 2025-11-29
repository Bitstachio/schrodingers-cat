using System;
using Features.Panel.Models;

namespace Features.Panel.Interfaces
{
    public interface IPanelService
    {
        public event EventHandler<PanelInteractionEventArgs> Opened;

        void Open(int panelId);
    }
}