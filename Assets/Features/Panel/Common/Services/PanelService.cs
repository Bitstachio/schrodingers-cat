using System;
using Features.Panel.Common.Interfaces;

namespace Features.Panel.Common.Services
{
    public class PanelService<T> : IPanelService<T>
    {
        public event EventHandler<T> Opened;

        public void Open(T content) => Opened?.Invoke(this, content);
    }
}