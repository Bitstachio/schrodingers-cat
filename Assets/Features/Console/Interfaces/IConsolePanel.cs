using Features.Console.Enums;

namespace Features.Console.Interfaces
{
    public interface IConsolePanel
    {
        void Show(int consoleId);
        void Hide();

        public int Id { get; }
        public ConsoleType Type { get; }
    }
}