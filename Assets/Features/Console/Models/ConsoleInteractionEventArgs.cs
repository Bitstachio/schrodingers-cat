using Features.Console.Enums;

namespace Features.Console.Models
{
    public class ConsoleInteractionEventArgs
    {
        public ConsoleType ConsoleType { get; }
        public int ConsoleId { get; }

        public ConsoleInteractionEventArgs(ConsoleType consoleType, int consoleId)
        {
            ConsoleType = consoleType;
            ConsoleId = consoleId;
        }
    }
}