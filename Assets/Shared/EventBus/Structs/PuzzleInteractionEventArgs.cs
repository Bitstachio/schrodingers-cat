namespace Shared.EventBus.Structs
{
    public struct PuzzleInteractionEventArgs
    {
        public int Id { get; }

        public PuzzleInteractionEventArgs(int id) => Id = id;
    }
}