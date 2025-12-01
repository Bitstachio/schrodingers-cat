namespace Features.Panel.StaticPanel.Models
{
    public class StaticPanelInteractionEventArgs
    {
        public int PanelId { get; }

        public StaticPanelInteractionEventArgs(int panelId)
        {
            PanelId = panelId;
        }
    }
}