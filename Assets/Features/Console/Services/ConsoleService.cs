using System;
using Features.Console.Enums;
using Features.Console.Exceptions;
using Features.Console.Interfaces;
using Features.Console.Models;

namespace Features.Console.Services
{
    public class ConsoleService : IConsoleService
    {
        //===== Events =====

        public event EventHandler<ConsoleInteractionEventArgs> Opened;

        //===== Actions =====

        public void Open(ConsoleType consoleType, int consoleId)
        {
            Opened?.Invoke(this, new ConsoleInteractionEventArgs(consoleType, consoleId));
        }
    }
}