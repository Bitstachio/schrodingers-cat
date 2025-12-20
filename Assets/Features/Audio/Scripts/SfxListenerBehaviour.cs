using Features.Audio.Interfaces;
using Shared.EventBus.Implementation;
using UnityEngine;
using VContainer;

namespace Features.Audio.Scripts
{
    public abstract class SfxListenerBehaviour<T> : EventListenerBehaviour<T>
    {
        [SerializeField] protected AudioClip audioClip;
        [SerializeField] private float volume = 1;

        private ISfxPlayer _sfxPlayer;

        [Inject]
        public void Construct(ISfxPlayer sfxPlayer) => _sfxPlayer = sfxPlayer;

        protected override void OnInvoked(T e) => _sfxPlayer.Play(audioClip, volume);
    }
}