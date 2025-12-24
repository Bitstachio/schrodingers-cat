using Features.Player.Interfaces;
using Shared.Enums;
using Shared.EventBus.Implementation;
using Shared.EventBus.Structs;

namespace Features.Player.Services
{
    public sealed class PlayerService : EventPublisherService<PlayerActionEventArgs>, IPlayerService
    {
        public void Attack() => Publisher.Invoke(new PlayerActionEventArgs(PlayerAction.Attack));
    }
}