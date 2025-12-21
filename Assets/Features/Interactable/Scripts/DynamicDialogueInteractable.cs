using Shared.EventBus.Structs;
using Shared.ScriptableObjects.Panel.Dialogue;
using Shared.StateMachine.Exceptions;
using Shared.StateMachine.Interfaces;
using UnityEngine;

namespace Features.Interactable.Scripts
{
    public class DynamicDialogueInteractable : InteractableBehaviour<DialogueInteractionEventArgs>
    {
        [SerializeField] private DialogueContent[] dialogues;

        private IStateMachine _state;

        private void Awake()
        {
            if (!TryGetComponent(out _state)) throw new MissingStateMachineException();
        }

        protected override void Interact() =>
            InteractableService.Apply(new DialogueInteractionEventArgs(dialogues[_state.Index]));
    }
}