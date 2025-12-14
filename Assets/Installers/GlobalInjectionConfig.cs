using System;
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
        };
    }
}