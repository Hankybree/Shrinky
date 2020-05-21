using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpAudio : MonoBehaviour
{
    private AudioSource[] sources;
    private int audioCounter;

    // Start is called before the first frame update
    void Start()
    {
        sources = GetComponents<AudioSource>();
        audioCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudio()
    {
        sources[audioCounter].Play();

        if(audioCounter < 3)
        {
            audioCounter++;
        }
        else
        {
            audioCounter = 0;
        }
    }
}
