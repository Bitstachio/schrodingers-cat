using System;
using Features.Door.Interfaces;
using Features.Interactable.Interfaces;
using Features.Puzzle.Interfaces;
using Shared.EventBus.Interfaces;

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