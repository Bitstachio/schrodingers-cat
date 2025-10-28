using System;
using Features.Console.Enums;
using Features.Console.Models;

namespace Features.Console.Interfaces
{
    public interface IConsoleService
    {
        public event EventHandler<ConsoleInteractionEventArgs> Opened;

        void Open(ConsoleType consoleType, int consoleId);
    }
}