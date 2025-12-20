using Features.Door.Interfaces;
using Shared.EventBus.Implementation;
using Shared.EventBus.Structs;
using UnityEngine;

namespace Features.Door.Services
{
    public class DoorService : EventPublisherService<DoorEventArgs>, IDoorService
    {
        public void Open() => Publisher.Invoke(new DoorEventArgs(DoorAction.Open));

        public void Close()
        {
            Debug.Log("Raising close door event...");
            Publisher.Invoke(new DoorEventArgs(DoorAction.Close));
        }
    }
}