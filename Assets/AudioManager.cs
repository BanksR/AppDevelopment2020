using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;

    private AudioSource _aud;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        _aud = GetComponent<AudioSource>();
    }


    public void PlayMe(AudioClip clip)
    {
        float randPitch = Random.Range(0.8f, 1.1f);
        float randVol = Random.Range(0.6f, 1f);

        _aud.pitch = randPitch;
        _aud.volume = randVol;
        _aud.PlayOneShot(clip);
    }
}
