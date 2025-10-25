using System;
using Features.Console.Interfaces;

namespace Features.Console.Services
{
    public class ConsoleService : IConsoleService
    {
        public event EventHandler Opened;
        public event EventHandler Closed;
        
        public void Open()
        {
            Opened?.Invoke(this, EventArgs.Empty);
        }

        public void Close()
        {
            Closed?.Invoke(this, EventArgs.Empty);
        }
    }
}