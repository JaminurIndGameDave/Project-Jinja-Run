using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public AudioClip clip;
    public string name;

    [Range(0, 1)]
    public float voloum;
    [HideInInspector]
    public AudioSource source;
    public bool loop;

}
