using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float PlayerBulletspeed=50f;
    private Rigidbody2D rbBullet; 
    //public GameObject ShotPrefab;
    // Start is called before the first frame update
    void Start()
    {
        rbBullet = GetComponent<Rigidbody2D>();
        rbBullet.velocity = transform.up *PlayerBulletspeed;
    }

    void OnCollisionEnter2D(Collision2D Bullet)
    {
        if(Bullet.transform.tag=="Enemy")
        {
            Destroy(gameObject);
        }else
        {
            Destroy(gameObject,10f);
        } 
    }

}
