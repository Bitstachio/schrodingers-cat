using System;

namespace Features.Console.Exceptions
{
    public class ConsoleAlreadyOpenException : Exception
    {
        public ConsoleAlreadyOpenException()
        {
        }

        public ConsoleAlreadyOpenException(string message)
            : base(message)
        {
        }

        public ConsoleAlreadyOpenException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}