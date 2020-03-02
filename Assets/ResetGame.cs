using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ResetGame : MonoBehaviour
{
    void OnTriggerEnter()
    {
        SceneManager.LoadScene("Room1", LoadSceneMode.Single); 
    }
}
