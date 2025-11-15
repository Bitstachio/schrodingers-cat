namespace Features.Console.Models
{
    public class ConsoleInteractionEventArgs
    {
        public int ConsoleId { get; }

        public ConsoleInteractionEventArgs(int consoleId)
        {
            ConsoleId = consoleId;
        }
    }
}