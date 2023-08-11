using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Player_Honk : MonoBehaviour
{

    private SC_Audio_Manager audioManager;
    private string Honk;


    private void Awake()
    {
        audioManager = GetComponent<SC_Audio_Manager>();
        Debug.Log(audioManager);
        Honk = "Honk";
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioManager.PlayRandomSound(Honk);
            Debug.Log(Honk);
        }
    }

    

}
