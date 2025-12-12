namespace Features.Panel.StaticPanel.Models
{
    public class LockPanelAttemptUnlockEventArgs
    {
        public bool Result { get; }

        public LockPanelAttemptUnlockEventArgs(bool result) => Result = result;
    }
}