using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    public GameObject EnemyDeath;
    public static int score;
    public float movSpeed;

    void FixedUpdate() 
    {
        transform.position += Vector3.down*movSpeed*Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collider) 
    {
        if(collider.transform.tag=="Bullet")
        {
            score+=1;
            gameObject.SetActive(false);
            GameObject Death =Instantiate(EnemyDeath,transform.position,transform.rotation);
            Destroy(Death,0.5f);
        }
    }
}
