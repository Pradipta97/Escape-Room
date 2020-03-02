using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; 

public class Talk2 : MonoBehaviour
{
    public Text toText; 
    string abcd = ("NPC: Now use this block to get up there!"); 
    private AudioSource aSource; 
    

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
