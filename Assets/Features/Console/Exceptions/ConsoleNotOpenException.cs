using System;

namespace Features.Console.Exceptions
{
    public class ConsoleNotOpenException : Exception
    {
        public ConsoleNotOpenException()
        {
        }

        public ConsoleNotOpenException(string message)
            : base(message)
        {
        }

        public ConsoleNotOpenException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}