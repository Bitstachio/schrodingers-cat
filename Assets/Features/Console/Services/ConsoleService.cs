using System;
using Features.Console.Interfaces;
using Features.Console.Models;

namespace Features.Console.Services
{
    public class ConsoleService : IConsoleService
    {
        //===== Events =====

        public event EventHandler<ConsoleInteractionEventArgs> Opened;

        //===== Actions =====

        public void Open(int consoleId)
        {
            Opened?.Invoke(this, new ConsoleInteractionEventArgs(consoleId));
        }
    }
}