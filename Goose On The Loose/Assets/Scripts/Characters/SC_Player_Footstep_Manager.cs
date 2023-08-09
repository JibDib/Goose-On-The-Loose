using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Player_Manager_Footsteps : MonoBehaviour
{
    
    public AudioSource footstepSoundSource;
    //public SC_AudioClip_List listOfFootstepSounds = new SC_AudioClip_List();
    public SC_AudioClip_List[] listOfFootstepSounds;
    private int listNumber = 0;


    /*public int PlayRandomFootstep(string type)
    {

        foreach(SC_AudioClip_List clipList in listOfFootstepSounds)
        {
            if (listOfFootstepSounds.type != type)
            {
                listNumber += 1;
            }
        }

        if (listOfFootstepSounds.type == type)
        {
            footstepSoundSource.PlayOneShot(listOfFootstepSounds.audioClips[Random.Range(0, listOfFootstepSounds.Length - 1)]);
        }

    }*/
    
    // Check each sublist for their type
    // Get the list that matches the type
    // Play a random sound
    //https://stackoverflow.com/questions/62670596/foreach-statement-cannot-operate-on-variables-of-type-table1-because-table1
}