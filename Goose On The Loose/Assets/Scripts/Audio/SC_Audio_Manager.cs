using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Audio_Manager : MonoBehaviour
{
    
    public AudioSource soundSource;
    public SC_AudioClip_List[] listOfSounds;
    private int listNumber = 0;
    private AudioClip selectedClip;


    private int GetCorrectType(string type)
    {

        foreach(SC_AudioClip_List clipList in listOfSounds)
        {
            if (listOfSounds[listNumber].type != type)
            {
                listNumber += 1;
            }
            else
            {
                return listNumber;
            }
        }
        return listNumber;
    }

    public void PlayRandomSound(string type)
    {
        GetCorrectType(type);
        
        // Pick & play a random clip from the correct list
        int n = Random.Range(1, listOfSounds[listNumber].audioClips.Length); //excludes item at index 0
        selectedClip = listOfSounds[listNumber].audioClips[n];
        soundSource.PlayOneShot(selectedClip);
        // Move picked sound to index 0 so it's not picked next tiem
        listOfSounds[listNumber].audioClips[n] = listOfSounds[listNumber].audioClips[0];
        listOfSounds[listNumber].audioClips[0] = selectedClip;

        listNumber = 0;
    }
}