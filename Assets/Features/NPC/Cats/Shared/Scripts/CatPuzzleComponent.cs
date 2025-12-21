using Features.NPC.Cats.Shared.Enums;
using Features.Puzzle.Interfaces;
using Shared.StateMachine.Exceptions;
using UnityEngine;

namespace Features.NPC.Cats.Shared.Scripts
{
    public class CatPuzzleComponent : MonoBehaviour, IPuzzleComponent
    {
        [SerializeField] private int puzzleId;
        [SerializeField] private CatState expected;

        private CatStateMachine _state;

        public int PuzzleId { get; private set; }

        private void Awake()
        {
            if (!TryGetComponent(out _state)) throw new MissingStateMachineException();
            PuzzleId = puzzleId;
        }

        public bool Evaluate() => _state.Current == expected;
    }
}