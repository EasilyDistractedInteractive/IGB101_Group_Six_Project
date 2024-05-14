using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Player;

    public Text pickupText;

    public int currentPickups = 0;
    public int maximumPickups = 5;
    [HideInInspector] public  bool levelComplete = false;

    public AudioSource[] AudioSources;
    public float audioProximity = 5.0f;

    void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
        PlayAudioSamples();

    }

    public void LevelCompleteCheck()
    {
        if(currentPickups >= maximumPickups)
        {
            levelComplete = true;
        }

        if(currentPickups < maximumPickups)
        {
            levelComplete = false;
        }
        
    }

    private void UpdateGUI()
    {
        pickupText.text = "Pickups: " + currentPickups + "/" + maximumPickups;
    }

    public void PlayAudioSamples()
    {
        for(int index = 0; index < AudioSources.Length; index++)
        {
            if(Vector3.Distance(Player.transform.position, AudioSources[index].transform.position) <= audioProximity)
            {
                if(!AudioSources[index].isPlaying)
                {
                    AudioSources[index].Play();
                    print("PLAYING");
                }
            }
        }
    }
}
