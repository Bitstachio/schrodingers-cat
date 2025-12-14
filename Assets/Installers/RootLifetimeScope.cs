using System.Linq;
using Features.Interactable.Interfaces;
using Features.Interactable.Services;
using Features.Panel.Common.Interfaces;
using Features.Panel.Common.Services;
using Shared.Events;
using Shared.Events.Interactable.Implementation;
using Shared.Events.Interactable.Interfaces;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Installers
{
    public class RootLifetimeScope : LifetimeScope
    {
        protected override void Awake()
        {
            base.Awake();
            DontDestroyOnLoad(gameObject);
        }

        protected override void Configure(IContainerBuilder builder)
        {
            //===== Global Interface Injection =====

            builder.RegisterBuildCallback(container =>
            {
                foreach (var behaviour in FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None))
                {
                    if (GlobalInjectionConfig.AutoInjectInterfaces.Any(iface =>
                            iface.IsAssignableFrom(behaviour.GetType())))
                    {
                        container.Inject(behaviour);
                    }
                }
            });

            //===== Events =====
            
            builder.Register(typeof(InteractableEvents<>), Lifetime.Singleton)
                .As(typeof(IInteractableEvents<>))
                .As(typeof(IInteractableEventPublisher<>));

            //===== Services =====

            builder.Register(typeof(PanelService<>), Lifetime.Singleton)
                .As(typeof(IPanelService<>))
                .AsSelf();
            
            builder.Register(typeof(InteractionService<>), Lifetime.Singleton)
                .As(typeof(IInteractableService<>));
        }
    }
}