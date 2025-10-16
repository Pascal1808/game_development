using System;
using UnityEngine;
using UnityEngine.Rendering;

public class score_calculator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     void Start()
    {

        playsong("Wake Up - AVICI");
        string CurrentSong = GetCurrentSong();
        Debug.Log("Current song: " + CurrentSong);
        SetVolume(0.8f);
        bool Playing = IsPlaying();
        if (Playing)
        {
            Debug.Log("is playing:");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            stopSong();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            stopSong();
        }
        
    }

    void playsong(string songname)
    {
        Debug.Log("playing song: " + songname);

    }
    string GetCurrentSong()
    {
        return "Wake Up - AVICI";
    }

    void stopSong()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("song stopped");
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("song is playing");
        }
    }
    
    void SetVolume(float volume)
    {
        if(Input.GetKeyDown(KeyCode.V))
        Debug.Log("volume set to:" + volume);
    }
    
    
}
