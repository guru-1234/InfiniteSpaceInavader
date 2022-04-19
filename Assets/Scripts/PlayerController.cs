using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    public float speed=100f;
    public float horizontal;
    public Transform GunHolder;
    public GameObject ShootingPerfab;
    public new AudioSource audio;
   
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal")*speed;
        Vector3 targetvelocity = new Vector2(horizontal,playerRigidbody.velocity.y);
        playerRigidbody.velocity = Vector2.right*targetvelocity;

        if(Input.GetButtonDown("Fire1"))
        {
            audio.Play();
            Instantiate(ShootingPerfab,GunHolder.position,GunHolder.rotation);
        }
    }

}
