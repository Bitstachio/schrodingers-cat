using Features.SFX.Interfaces;
using Shared.EventBus.Implementation;
using UnityEngine;
using VContainer;

namespace Features.SFX.Scripts
{
    public abstract class SfxListenerBehaviour<T> : EventListenerBehaviour<T>
    {
        [SerializeField] protected AudioClip audioClip;

        private ISfxPlayer _sfxPlayer;

        [Inject]
        public void Construct(ISfxPlayer sfxPlayer) => _sfxPlayer = sfxPlayer;

        protected override void OnInvoked(T e) => _sfxPlayer.Play(audioClip);
    }
}