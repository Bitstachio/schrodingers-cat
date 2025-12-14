namespace Shared.EventBus.Structs
{
    public readonly struct LockPanelAttemptUnlockEventArgs
    {
        public bool Result { get; }

        public LockPanelAttemptUnlockEventArgs(bool result) => Result = result;
    }
}