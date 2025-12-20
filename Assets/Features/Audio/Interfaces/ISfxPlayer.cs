using UnityEngine;

namespace Features.Audio.Interfaces
{
    public interface ISfxPlayer
    {
        void Play(AudioClip audioClip, float volume);
    }
}