namespace Shared.EventBus.Structs
{
    public enum DoorAction
    {
        Open,
        Close
    }

    public struct DoorEventArgs
    {
        public DoorAction Action { get; }

        public DoorEventArgs(DoorAction action) => Action = action;
    }
}