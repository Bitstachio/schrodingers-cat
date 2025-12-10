using System.Linq;
using Features.Common.Interactable.Interfaces;
using Features.Panel.Banner.Scripts;
using Features.Panel.Common.Interfaces;
using Features.Panel.Common.Services;
using Features.Panel.Dialogue.Scripts;
using Features.Panel.StaticPanel.Interfaces;
using Features.Panel.StaticPanel.Scripts;
using Features.Panel.StaticPanel.Services;
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
            //===== Panel Service =====

            builder.Register<IPanelService, StaticPanelService>(Lifetime.Singleton);

            builder.RegisterBuildCallback(container =>
            {
                var triggers = FindObjectsByType<StaticPanelInteractable>(FindObjectsSortMode.None);
                foreach (var trigger in triggers) container.Inject(trigger);
            });
            builder.RegisterComponentInHierarchy<StaticPanelDispatcher>();

            //===== Dialogue Service =====

            builder.RegisterComponentInHierarchy<DialogueDispatcher>();

            //===== Banner Service =====

            builder.RegisterComponentInHierarchy<BannerDispatcher>();

            //===== Panel Service =====

            builder.Register(typeof(PanelService<>), Lifetime.Singleton)
                .As(typeof(IPanelService<>))
                .AsSelf();

            // Inject into all interface inheritors
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
        }
    }
}