using Features.Console.Interfaces;
using Features.Console.Services;
using Puzzle.Script;
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
            builder.RegisterComponentInHierarchy<PuzzleTrigger>();
        }
    }
}