using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
     public static SoundManager soundManager;

    private AudioSource source;

    public AudioClip[] sounds;

    private int randomExplosionSound;
    // Start is called before the first frame update
    void Start()
    {
        soundManager = this;
        source = GetComponent<AudioSource>();
        sounds = Resources.LoadAll<AudioClip>("Explosion");
    }

    public void PlayExplosionSound()
    {
        randomExplosionSound = Random.Range(1,6);
        source.PlayOneShot(sounds[randomExplosionSound]);
    }
}
