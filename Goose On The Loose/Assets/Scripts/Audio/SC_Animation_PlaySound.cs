using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script was built for Scarlet Is The Night In Which We Break and then revamped during the development of A Vacancy That's Hard to Talk About
// Put it on an object that has an animator, and add every sound that object can make during an animation to the list
// Now in any of it's animations, call the function using an event, and pass in the list number that corresponds to the sound you want to play (0 is the first item, 1 is the second, and so on)


public class SC_Animation_PlaySound : MonoBehaviour
{
    public AudioSource[] soundSources; // Creates a list of audio sources you can add to in the inspector
    public AudioClip[] soundEffects;


    public void playSound(int sourceNumber, int clipNumber)
    {
        AudioSource selectedSource = soundSources[sourceNumber];
        AudioClip selectedClip = soundEffects[clipNumber];

        selectedSource.clip = selectedClip;
        selectedSource.Play();
 
    }

   /* public void playSound(int clipNumber) //When you run the function, put in the number of the clip you want to play
    {
        AudioSource clip = soundEffects[clipNumber];
        clip.Play();
    }

    public void stopSound(int clipNumber)
    {
        AudioSource clip = soundEffects[clipNumber];
        clip.Stop();
    }*/
}
