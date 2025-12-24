using Features.Player.Interfaces;
using UnityEngine;
using VContainer;

namespace Features.Player.Scripts
{
    public class PlayerActionBehaviour : MonoBehaviour, IPlayerAction
    {
        protected IPlayerService PlayerService;

        [Inject]
        public void Construct(IPlayerService playerService) => PlayerService = playerService;
    }
}