# Audio

## Volume Handling

The SFX player exposes a volume parameter, whereas the music player does not.
This is because the music player is responsible for playing a single music track at a time, and its volume can be
controlled directly through its `AudioSource` component.
In contrast, multiple SFX listeners share the same `AudioSource`.
To allow each sound effect to be played at an appropriate relative loudness, the SFX player accepts a volume parameter
that can be specified per SFX listener.