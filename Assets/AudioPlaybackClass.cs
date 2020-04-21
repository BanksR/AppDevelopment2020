using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlaybackClass : MonoBehaviour
{

    public AudioClip _sfx;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))

            {
            AudioManager.instance.PlayMe(_sfx);
            }
    }
}
