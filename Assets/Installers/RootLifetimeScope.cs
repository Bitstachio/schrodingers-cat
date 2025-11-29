using Features.Panel.Interfaces;
using Features.Panel.Scripts;
using Features.Panel.Services;
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
            builder.Register<IPanelService, PanelService>(Lifetime.Singleton);

            builder.RegisterBuildCallback(container =>
            {
                var triggers = FindObjectsByType<PanelTrigger>(FindObjectsSortMode.None);
                foreach (var trigger in triggers) container.Inject(trigger);
            });
            builder.RegisterComponentInHierarchy<PanelDispatcher>();
        }
    }
}