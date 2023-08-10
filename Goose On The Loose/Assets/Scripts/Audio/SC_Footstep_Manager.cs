using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Footstep_Manager : MonoBehaviour
{
    
    public AudioSource footstepSoundSource;
    public SC_AudioClip_List[] listOfFootstepSounds;
    private int listNumber = 0;


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
        footstepSoundSource.PlayOneShot(listOfFootstepSounds[listNumber].audioClips[Random.Range(0, listOfFootstepSounds[listNumber].audioClips.Length - 1)]);
        listNumber = 0;
    }
    
    // Check each sublist for their type
    // Get the list that matches the type
    // Play a random sound
    //https://stackoverflow.com/questions/62670596/foreach-statement-cannot-operate-on-variables-of-type-table1-because-table1
}