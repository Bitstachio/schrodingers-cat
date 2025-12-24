using Shared.Enums;

namespace Shared.EventBus.Structs
{
    public struct PlayerActionEventArgs
    {
        private PlayerAction Action { get; }

        public PlayerActionEventArgs(PlayerAction action) => Action = action;
    }
}