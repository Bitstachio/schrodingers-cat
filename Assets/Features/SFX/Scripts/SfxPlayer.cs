using Features.SFX.Interfaces;
using UnityEngine;

namespace Features.SFX.Scripts
{
    [RequireComponent(typeof(AudioSource))]
    public class SfxPlayer : MonoBehaviour, ISfxPlayer
    {
        private AudioSource _audioSource;

        private void Awake() => _audioSource = GetComponent<AudioSource>();

        public void Play(AudioClip audioClip, float volume) => _audioSource.PlayOneShot(audioClip, volume);
    }
}