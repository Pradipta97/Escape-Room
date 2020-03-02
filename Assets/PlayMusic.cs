using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    private AudioSource aSource; 

    void Start()
    {
        aSource = GetComponent<AudioSource>(); 
    }
    void OnTriggerEnter()
    {
        aSource.Play(); 
    }

}
