namespace Features.Panel.Interfaces
{
    public interface IPanel
    {
        void Show(int panelId);
        void Hide();

        public int Id { get; }
    }
}