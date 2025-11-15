using Features.Console.Enums;

namespace Features.Console.Interfaces
{
    public interface IConsolePanel
    {
        void Show(int consoleId);
        void Hide();

        public int ConsoleId { get; }
        public ConsoleType ConsoleType { get; }
    }
}