using Features.Console.Enums;

namespace Features.Console.Interfaces
{
    public interface IConsolePanel
    {
        void Show(int id);
        void Hide();

        public ConsoleType Type { get; }
    }
}