using System;
using Features.Console.Enums;
using Features.Console.Interfaces;
using Features.Console.Models;
using UnityEngine;

namespace Features.Console.Services
{
    public class ConsoleService : IConsoleService
    {
        public event EventHandler<ConsoleOpenEventArgs> Opened;
        public event EventHandler Closed;

        public void Open(ConsoleType consoleType, int consoleId)
        {
            Opened?.Invoke(this, new ConsoleOpenEventArgs(consoleType, consoleId));
        }

        public void Close()
        {
            Debug.Log("Console has been closed");
            Closed?.Invoke(this, EventArgs.Empty);
        }
    }
}