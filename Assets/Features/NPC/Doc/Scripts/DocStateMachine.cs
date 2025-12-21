using Features.NPC.Shared.Constants;
using Shared.EventBus.Interfaces;
using Shared.EventBus.Structs;
using Shared.StateMachine.Interfaces;
using UnityEngine;
using VContainer;

namespace Features.NPC.Doc.Scripts
{
    public class DocStateMachine : MonoBehaviour, IStateMachine, IEventListener
    {
        /**
         * 0: Base
         * 1: Had the initial dialogue with player and introduced the puzzle
         * 2: Assesses the puzzle attempt
         */
        public int Index { get; private set; }

        private IEvent<DialogueInteractionEventArgs> _dialogueEvent;
        private IEvent<PuzzleAttemptEventArgs> _puzzleEvent;

        [Inject]
        public void Construct(
            IEvent<DialogueInteractionEventArgs> dialogueEvent,
            IEvent<PuzzleAttemptEventArgs> puzzleEvent)
        {
            _dialogueEvent = dialogueEvent;
            _puzzleEvent = puzzleEvent;
        }

        private void OnEnable()
        {
            _dialogueEvent.Invoked += HandleDialogueEvent;
            _puzzleEvent.Invoked += HandlePuzzleEvent;
        }

        private void OnDisable()
        {
            _dialogueEvent.Invoked -= HandleDialogueEvent;
            _puzzleEvent.Invoked -= HandlePuzzleEvent;
        }

        private void HandleDialogueEvent(DialogueInteractionEventArgs e)
        {
            if (Index == 0 && e.Dialogue.Speaker == Speakers.Doc) Index++;
        }

        private void HandlePuzzleEvent(PuzzleAttemptEventArgs e)
        {
            if (Index == 1 && e.Result) Index++;
        }
    }
}