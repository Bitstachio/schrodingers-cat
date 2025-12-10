using System;
using Features.Common.Interactable.Interfaces;

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