using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserLogic : MonoBehaviour
{
    public float speed = 20f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*EnemyBase enemy = collision.GetComponent<EnemyBase>();
        if(enemy != null)
        {
 
        }*/

        Destroy(gameObject); 
    }
}
