using System;

namespace Features.Panel.Common.Interfaces
{
    public interface IPanelService<T>
    {
        public event EventHandler<T> Opened;
        
        void Open(T content);
    }
}