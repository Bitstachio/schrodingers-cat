using System;
using Features.Console.Models;

namespace Features.Console.Interfaces
{
    public interface IConsoleService
    {
        public event EventHandler<ConsoleInteractionEventArgs> Opened;

        void Open(int consoleId);
    }
}