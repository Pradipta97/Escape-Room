using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScene : MonoBehaviour
{
    private GameObject music; 
    SceneChanger sc; 

    void Awake()
{
    GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

    if(objs.Length > 1)
    {
    Destroy(this.gameObject);  
    }

    DontDestroyOnLoad(this.gameObject); 
}

void Start()
{
    music = GameObject.FindWithTag("music"); 

}

   public void Play()
   {
       SceneManager.LoadScene("Play", LoadSceneMode.Single); 
   }

   public void Credits()
   {
       SceneManager.LoadScene("Credits", LoadSceneMode.Single); 

       
   }

   public void Settings()
   {
       SceneManager.LoadScene("Settings", LoadSceneMode.Single); 
   }

   public void Back()
   {
       SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
   }

   public void turnoffMusic()
   {
         Destroy(music);
   }

   public void reStore()
   {
       sc.isDone = true; 
   }

   
}
