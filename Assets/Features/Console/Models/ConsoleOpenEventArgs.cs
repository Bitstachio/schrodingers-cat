using Features.Console.Enums;

namespace Features.Console.Models
{
    public class ConsoleOpenEventArgs
    {
        public ConsoleType ConsoleType { get; }
        public int ConsoleId { get; }

        public ConsoleOpenEventArgs(ConsoleType consoleType, int consoleId)
        {
            ConsoleType = consoleType;
            ConsoleId = consoleId;
        }
    }
}