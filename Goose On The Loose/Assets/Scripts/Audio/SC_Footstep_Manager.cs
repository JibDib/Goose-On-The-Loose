using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Footstep_Manager : MonoBehaviour
{
    
    public AudioSource footstepSoundSource;
    public SC_AudioClip_List[] listOfFootstepSounds;
    private int listNumber = 0;
    private AudioClip selectedClip;


    private int GetCorrectType(string type)
    {

        foreach(SC_AudioClip_List clipList in listOfFootstepSounds)
        {
            if (listOfFootstepSounds[listNumber].type != type)
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

    public void PlayFootstepSound(string type)
    {
        GetCorrectType(type);
        
        // Pick & play a random clip from the correct list
        int n = Random.Range(1, listOfFootstepSounds[listNumber].audioClips.Length); //excludes item at index 0
        selectedClip = listOfFootstepSounds[listNumber].audioClips[n];
        footstepSoundSource.PlayOneShot(selectedClip);
        // Move picked sound to index 0 so it's not picked next tiem
        listOfFootstepSounds[listNumber].audioClips[n] = listOfFootstepSounds[listNumber].audioClips[0];
        listOfFootstepSounds[listNumber].audioClips[0] = selectedClip;

        listNumber = 0;
    }
}