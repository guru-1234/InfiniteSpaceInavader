using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    public Gamemanager Gamemanager;

    public void OnTriggerEnter2D(Collider2D End) 
    {
        if(End.transform.tag=="Enemy")
        {
            Gamemanager.GameOver();
        }
        
    }
}
