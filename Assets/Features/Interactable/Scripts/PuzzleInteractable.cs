using Shared.EventBus.Structs;
using UnityEngine;

namespace Features.Interactable.Scripts
{
    public class PuzzleInteractable : InteractableBehaviour<PuzzleInteractionEventArgs>
    {
        [SerializeField] private int puzzleId;

        protected override void Interact() => InteractableService.Apply(new PuzzleInteractionEventArgs(puzzleId));
    }
}