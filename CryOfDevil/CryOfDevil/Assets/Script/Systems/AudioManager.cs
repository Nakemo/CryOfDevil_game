using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private Sound[] sounds;

    public Sound[] Sounds { get => sounds; set => sounds = value; }

    void Awake()
    {
        foreach (Sound s in souunds) 
        {
            
        }
    }

    void Update()
    {
        
    }
}
