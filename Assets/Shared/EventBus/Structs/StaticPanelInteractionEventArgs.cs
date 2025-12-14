namespace Shared.EventBus.Structs
{
    public readonly struct StaticPanelInteractionEventArgs
    {
        public int PanelId { get; }

        public StaticPanelInteractionEventArgs(int panelId) => PanelId = panelId;
    }
}