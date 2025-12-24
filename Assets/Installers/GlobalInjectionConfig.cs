using System;
using Features.Door.Interfaces;
using Features.Interactable.Interfaces;
using Features.Player.Interfaces;
using Shared.EventBus.Interfaces;
using Shared.Puzzle.Interfaces;

namespace Installers
{
    public static class GlobalInjectionConfig
    {
        public static readonly Type[] AutoInjectInterfaces =
        {
            typeof(IInteractable),
            typeof(IEventListener),
            typeof(IPlayerAction),
            typeof(IPuzzle),
            typeof(IDoor),
        };
    }
}