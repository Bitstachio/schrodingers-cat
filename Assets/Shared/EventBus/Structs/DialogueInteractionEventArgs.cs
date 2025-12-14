using Shared.ScriptableObjects.Panel.Dialogue;

namespace Shared.EventBus.Structs
{
    public readonly struct DialogueInteractionEventArgs
    {
        public DialogueContent Dialogue { get; }

        public DialogueInteractionEventArgs(DialogueContent dialogue) => Dialogue = dialogue;
    }
}