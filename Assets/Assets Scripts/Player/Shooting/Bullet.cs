﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 200f;
    public int damage = 100;
    public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb.velocity = transform.right * speed;
       
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(100);
        }
        Destroy(gameObject);
    }

    // Update is called once per frame
}
