using Features.Console.Enums;

namespace Features.Console.Interfaces
{
    public interface IConsolePanel
    {
        void Show(int consoleId);
        void Hide();

        public ConsoleType ConsoleType { get; }
    }
}