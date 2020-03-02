using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talk4 : MonoBehaviour
{
    private AudioSource aSource; 
   

    public Text toText; 
    string abcd = ("NPC: Final Puzzle! Destroy the platforms and get the cubes!"); 


    void Start()
    {
      aSource = GetComponent<AudioSource>(); 
    }
    

    // Update is called once per frame
    void OnTriggerEnter()
    {
      toText.text = (" " + abcd); 
      aSource.Play(); 
    }

    void OnTriggerExit()
    {
      toText.text = (" "); 
       
      aSource.Stop(); 
    }
}

