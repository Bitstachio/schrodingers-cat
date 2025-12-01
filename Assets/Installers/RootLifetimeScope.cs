using Features.Panel.Dialogue.Interfaces;
using Features.Panel.Dialogue.Scripts;
using Features.Panel.Dialogue.Services;
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
            
            builder.Register<IDialogueService, DialogueService>(Lifetime.Singleton);

            builder.RegisterBuildCallback(container =>
            {
                var triggers = FindObjectsByType<DialogueInteractable>(FindObjectsSortMode.None);
                foreach (var trigger in triggers) container.Inject(trigger);
            });
            builder.RegisterComponentInHierarchy<DialogueDispatcher>();
        }
    }
}