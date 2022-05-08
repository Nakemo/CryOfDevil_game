//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System;
//using UnityEngine.Audio;

//public class AudioManager : MonoBehaviour
//{
//    public Sound[] sounds;
//    public Sound[] walking;

//    void Awake()
//    {
//        SetupAudioSource(walking);        
//    }

//    public void Play(string name) 
//    {
//        var sound = Array.Find(sounds, sound => sound.soundName == name);
//        sound._source.Play();
//    }

//    public void PlayStepSound() 
//    {
//        var source = RandomAudio(walking);
//        source.Play();
//    }

//    private AudioSource RandomAudio(Sound[] sounds) 
//    {
//        foreach (Sound sound in sounds) 
//        {
//            sound._source = gameObject.AddComponent<AudioSource>();
//            sound._source.clip = sound.clip;
//            sound._source.volume = sound.volume;
//            sound._source.pitch = sound.pitch;
//        }
//    }

//}
