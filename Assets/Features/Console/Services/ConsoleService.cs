using System;
using Features.Console.Interfaces;
using UnityEngine;

namespace Features.Console.Services
{
    public class ConsoleService : IConsoleService
    {
        public event EventHandler Opened;
        public event EventHandler Closed;
        
        public void Open()
        {
            Debug.Log("Console has been opened");
            Opened?.Invoke(this, EventArgs.Empty);
        }

        public void Close()
        {
            Debug.Log("Console has been closed");
            Closed?.Invoke(this, EventArgs.Empty);
        }
    }
}