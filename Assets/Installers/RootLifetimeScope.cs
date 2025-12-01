using Features.Dialogue.Interface;
using Features.Dialogue.Scripts;
using Features.Dialogue.Services;
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
            //===== Panel Service =====
            
            builder.Register<IPanelService, PanelService>(Lifetime.Singleton);

            builder.RegisterBuildCallback(container =>
            {
                var triggers = FindObjectsByType<PanelInteractable>(FindObjectsSortMode.None);
                foreach (var trigger in triggers) container.Inject(trigger);
            });
            builder.RegisterComponentInHierarchy<PanelDispatcher>();

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