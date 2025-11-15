namespace Features.Console.Interfaces
{
    public interface IConsolePanel
    {
        void Show(int consoleId);
        void Hide();

        public int Id { get; }
    }
}