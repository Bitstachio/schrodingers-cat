namespace Shared.EventBus.Structs
{
    public readonly struct PuzzleAttemptEventArgs
    {
        public bool Result { get; }

        public PuzzleAttemptEventArgs(bool result) => Result = result;
    }
}