using System.Linq;
using Features.Puzzle.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace Features.Puzzle.Scripts
{
    public class TogglePuzzle : MonoBehaviour, IPuzzle
    {
        [SerializeField] private Toggle[] toggles;
        [SerializeField] private bool[] key;

        private IPuzzleService _puzzleService;

        [Inject]
        public void Construct(IPuzzleService puzzleService) => _puzzleService = puzzleService;

        public void Attempt() => _puzzleService.Attempt(toggles.Select(t => t.isOn).ToArray(), key);
    }
}