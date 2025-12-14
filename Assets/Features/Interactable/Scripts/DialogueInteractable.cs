using Features.Interactable.Interfaces;
using Features.Panel.Common.Interfaces;
using Shared.EventBus.Structs;
using Shared.ScriptableObjects.Panel.Dialogue;
using UnityEngine;
using VContainer;

namespace Features.Interactable.Scripts
{
    public class DialogueInteractable : MonoBehaviour, IInteractable
    {
        [SerializeField] private DialogueContent dialogue;

        //===== Dependency Injection =====

        private IPanelService<DialogueInteractionEventArgs> _panelService;

        [Inject]
        public void Construct(IPanelService<DialogueInteractionEventArgs> panelService) => _panelService = panelService;

        //===== Interface Implementation =====

        public void Interact() => _panelService.Open(new DialogueInteractionEventArgs(dialogue));
    }
}