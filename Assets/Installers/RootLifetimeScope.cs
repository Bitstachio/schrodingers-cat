using System.Linq;
using Features.Audio.Interfaces;
using Features.Audio.Scripts;
using Features.Door.Interfaces;
using Features.Door.Services;
using Features.Interactable.Interfaces;
using Features.Interactable.Services;
using Features.Task.Interfaces;
using Features.Task.Services;
using Shared.EventBus.Implementation;
using Shared.EventBus.Interfaces;
using Shared.Puzzle.Interfaces;
using Shared.Puzzle.Services;
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
                foreach (var behaviour in FindObjectsByType<MonoBehaviour>(
                             FindObjectsInactive.Include,
                             FindObjectsSortMode.None))
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

            builder.Register(typeof(InteractionService<>), Lifetime.Singleton)
                .As(typeof(IInteractableService<>));

            builder.Register<PuzzleService>(Lifetime.Singleton)
                .As<IPuzzleService>();

            builder.Register<TaskService>(Lifetime.Singleton)
                .As<ITaskService>();
            
            builder.RegisterComponentInHierarchy<SfxPlayer>()
                .As<ISfxPlayer>();
            
            builder.Register<DoorService>(Lifetime.Singleton)
                .As<IDoorService>();
        }
    }
}