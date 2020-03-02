using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    private AudioSource aSource; 
    
    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown("w"))
        {
            if(aSource)
            aSource.Play(); 
        }
        
        
    }
}
