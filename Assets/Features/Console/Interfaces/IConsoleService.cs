using System;

namespace Features.Console.Interfaces
{
    public interface IConsoleService
    {
        event EventHandler Opened;
        event EventHandler Closed;
        
        void Open();
        void Close();
    }
}