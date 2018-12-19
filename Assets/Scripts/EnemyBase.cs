using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer rend;
    public float speed = 2f;
    public int health = 5;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        rend.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }


    public virtual void Update()
    {

    }
}
