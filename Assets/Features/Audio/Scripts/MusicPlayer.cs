using UnityEngine;

namespace Features.Audio.Scripts
{
    [RequireComponent(typeof(AudioSource))]
    public class MusicPlayer : MonoBehaviour
    {
        [SerializeField] private AudioClip audioClip;

        private AudioSource _audioSource;

        private void Awake() => _audioSource = GetComponent<AudioSource>();

        private void Start()
        {
            _audioSource.clip = audioClip;
            _audioSource.loop = true;
            _audioSource.Play();
        }
    }
}