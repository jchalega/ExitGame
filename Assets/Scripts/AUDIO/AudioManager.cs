using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer mixer;

    void Start()
    {
        mixer.SetFloat("MusicVolume", -20f);
        mixer.SetFloat("SFXVolume", 5f);
    }

    public void SetMusicVolume(float volume)
    {
        mixer.SetFloat("MusicVolume", volume);
    }

    public void SetSFXVolume(float volume)
    {
        mixer.SetFloat("SFXVolume", volume);
    }
}