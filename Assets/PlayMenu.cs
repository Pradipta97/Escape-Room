using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayMenu : MonoBehaviour
{
    SceneChanger sc; 
    public void Room1()
    {
        SceneManager.LoadScene("Room1", LoadSceneMode.Single); 
    }

    public void Room2()
    {
        if(sc.isDone)
        SceneManager.LoadScene("Room2", LoadSceneMode.Single); 
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single); 
    }
}
