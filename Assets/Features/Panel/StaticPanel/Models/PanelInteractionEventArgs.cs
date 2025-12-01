namespace Features.Panel.StaticPanel.Models
{
    public class PanelInteractionEventArgs
    {
        public int PanelId { get; }

        public PanelInteractionEventArgs(int panelId)
        {
            PanelId = panelId;
        }
    }
}