using Features.Console.Interfaces;
using Features.Console.Repositories;
using Features.Console.Scripts;
using Features.Console.Services;
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
            builder.Register<IConsoleService, ConsoleService>(Lifetime.Singleton);
            builder.Register<IConsoleStateRepository, ConsoleStateRepository>(Lifetime.Singleton);

            builder.RegisterBuildCallback(container =>
            {
                var triggers = FindObjectsByType<ConsoleTrigger>(FindObjectsSortMode.None);
                foreach (var trigger in triggers) container.Inject(trigger);
            });
        }
    }
}