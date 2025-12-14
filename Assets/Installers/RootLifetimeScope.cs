using System.Linq;
using Features.Interactable.Interfaces;
using Features.Interactable.Services;
using Features.Panel.Common.Interfaces;
using Features.Panel.Common.Services;
using Shared.EventBus.Implementation;
using Shared.EventBus.Interfaces;
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
            
            builder.Register(typeof(EventBus<>), Lifetime.Singleton)
                .As(typeof(IEvent<>))
                .As(typeof(IEventPublisher<>));

            //===== Services =====

            builder.Register(typeof(PanelService<>), Lifetime.Singleton)
                .As(typeof(IPanelService<>))
                .AsSelf();
            
            builder.Register(typeof(InteractionService<>), Lifetime.Singleton)
                .As(typeof(IInteractableService<>));
        }
    }
}