namespace Features.Panel.StaticPanel.Interfaces
{
    // TODO: Remove this interface after creating generic IPanel
    public interface IStaticPanel
    {
        void Show(int panelId);
        void Hide();

        public int Id { get; }
    }
}