using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Talk : MonoBehaviour
{
    private AudioSource aSource; 
    public Text toText; 
    string abcd = ("NPC: Find the keys and get out of here!"); 
    

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
