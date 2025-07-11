using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource soundSource;
    [SerializeField] private AudioSource musicSource;

    public void PlaySound(AudioClip clip)
    { 
        soundSource.PlayOneShot(clip); 
    }

    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.Play();
    }

    public void StopMusic() => musicSource.Stop();
    public void SetMusicVolume(int volume)
        => musicSource.volume = volume;
}
