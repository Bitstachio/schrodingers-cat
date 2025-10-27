using System;
using Features.Console.Enums;
using Features.Console.Models;

namespace Features.Console.Interfaces
{
    public interface IConsoleService
    {
        public event EventHandler<ConsoleOpenEventArgs> Opened;
        event EventHandler Closed;

        void Open(ConsoleType consoleType, int consoleId);
        void Close();
    }
}