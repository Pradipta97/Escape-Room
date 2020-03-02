using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    private AudioSource aSource;
    void Start()
    {
          aSource = GetComponent<AudioSource>(); 
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("destroy")) 
        {
            aSource.Play(); 
         Destroy(GameObject.FindWithTag("destroy")); 
        }

        if(col.gameObject.CompareTag("destroy1")) 
        {
            aSource.Play(); 
         Destroy(GameObject.FindWithTag("destroy1")); 
        }
    }

}
