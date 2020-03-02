using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Talk3 : MonoBehaviour
{
  private AudioSource aSource; 
   

    public Text toText; 
    string abcd = ("NPC: You made it to the second level! Now complete this to finish the game!"); 


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

