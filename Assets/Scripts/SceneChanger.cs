using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class SceneChanger : MonoBehaviour
{
    
 public  bool isDone;
   
   void OnTriggerEnter(Collider collider)
   {
       
       if(collider.gameObject.CompareTag("Player"))
       {
       isDone = true; 
       SceneManager.LoadScene("Room2", LoadSceneMode.Single); 
       }
   }



}
