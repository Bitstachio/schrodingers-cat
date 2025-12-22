using Shared.EventBus.Implementation;
using Shared.EventBus.Structs;
using UnityEngine;

namespace Features.Door.Scripts
{
    public class DoorPuzzleListener : EventListenerBehaviour<PuzzleAttemptEventArgs>
    {
        [SerializeField] private DoorBehaviour door;
        [SerializeField] private int puzzleId;

        protected override void OnInvoked(PuzzleAttemptEventArgs e)
        {
            if (e.Id == puzzleId && e.Result) door.Open();
        }
    }
}