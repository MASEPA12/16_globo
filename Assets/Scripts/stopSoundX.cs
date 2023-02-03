using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopSoundX : MonoBehaviour
{
    private AudioSource MyAudioSource;
    public PlayerControllerX playerControllerScript;

    void Start()
    {
        MyAudioSource = GetComponent<AudioSource>();
        playerControllerScript = FindObjectOfType<PlayerControllerX>();
    }

    void Update()
    {   //if it is game over the music will stop
        if (playerControllerScript.gameOver)
        {
            MyAudioSource.Stop();
        }
    }
}
