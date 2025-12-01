using System;
using Features.Panel.StaticPanel.Models;

namespace Features.Panel.StaticPanel.Interfaces
{
    public interface IPanelService
    {
        public event EventHandler<StaticPanelInteractionEventArgs> Opened;

        void Open(int panelId);
    }
}