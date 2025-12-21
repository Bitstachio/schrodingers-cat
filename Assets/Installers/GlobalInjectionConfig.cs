using System;
using Features.Door.Interfaces;
using Features.Interactable.Interfaces;
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
            typeof(IPuzzle),
            typeof(IDoor),
        };
    }
}