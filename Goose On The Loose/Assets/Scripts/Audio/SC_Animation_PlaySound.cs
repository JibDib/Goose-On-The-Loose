using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script was built for Scarlet Is The Night In Which We Break and then revamped during the development of A Vacancy That's Hard to Talk About
// Put it on an object that has an animator, and add every audio source that object uses to make sound
// Now in any of it's animations, call the function using an event, and pass in an int that corresponds with the list number of the audio source you want to use, and pass in the audio clip you want to play as an object
// The string and float values are not used for anything.


public class SC_Animation_PlaySound : MonoBehaviour
{
    public AudioSource[] soundSources; // Creates a list of audio sources you can add to in the inspector


    public void PlaySound(AnimationEvent myEvent) {

        AudioSource selectedSource = soundSources[myEvent.intParameter];
        AudioClip selectedClip = myEvent.objectReferenceParameter as AudioClip;



        selectedSource.clip = selectedClip;
        selectedSource.Play();
 
    }

    public void StopSound(int selectedSource)
    {
        AudioSource source = soundSources[selectedSource];
        source.Stop();
    }

}
