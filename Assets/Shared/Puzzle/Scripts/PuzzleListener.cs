using System.Linq;
using Shared.EventBus.Implementation;
using Shared.EventBus.Structs;
using Shared.Puzzle.Interfaces;
using UnityEngine;
using VContainer;

namespace Shared.Puzzle.Scripts
{
    public class PuzzleListener : EventListenerBehaviour<PuzzleInteractionEventArgs>
    {
        [SerializeField] private int id;

        private IPuzzleService _puzzleService;
        private IPuzzleComponent[] _components;

        [Inject]
        public void Construct(IPuzzleService puzzleService) => _puzzleService = puzzleService;

        private void Awake()
        {
            _components = FindObjectsByType<MonoBehaviour>(FindObjectsInactive.Include, FindObjectsSortMode.None)
                .OfType<IPuzzleComponent>()
                .Where(c => c.PuzzleId == id)
                .ToArray();
        }

        protected override void OnInvoked(PuzzleInteractionEventArgs e) =>
            _puzzleService.Attempt(id, _components.Select(c => c.Check()).ToArray());
    }
}