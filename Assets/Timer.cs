using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 


public class Timer : MonoBehaviour
{
    public int timeLeft = 60; 

    public Text countdown; 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LoseTime"); 
    }

    // Update is called once per frame
    void Update()
    {
        countdown.text = (" " + timeLeft); 
        if(timeLeft < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }
    }

    IEnumerator LoseTime()
    {
        while(true)
        {
            yield return new WaitForSeconds(1); 
            timeLeft--; 
        }
    }
}
