using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatforM : MonoBehaviour
{
    public GameObject Player; 
    
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject == Player)
        Player.transform.parent = transform;
    }

    private void OnTriggerExit(Collider col)
    {
        if(col.gameObject == Player)
        Player.transform.parent = null;
    }
}
