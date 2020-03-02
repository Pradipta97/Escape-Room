using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class PlayerFallTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Player"))
        SceneManager.LoadScene("Room1", LoadSceneMode.Single); 
    }
}
