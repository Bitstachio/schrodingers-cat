namespace Shared.EventBus.Structs
{
    public readonly struct PuzzleAttemptEventArgs
    {
        public int Id { get; }
        public bool Result { get; }

        public PuzzleAttemptEventArgs(int id, bool result)
        {
            Id = id;
            Result = result;
        }
    }
}