using System;
using Features.Interactable.Interfaces;

namespace Installers
{
    public static class GlobalInjectionConfig
    {
        public static readonly Type[] AutoInjectInterfaces =
        {
            typeof(IInteractable),
            typeof(IInteractionDispatcher),
        };
    }
}