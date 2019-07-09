﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public Vector2 flipDirection;
    public float speed = 200f;
    public int damage = 100;
    public Rigidbody2D rb;
	
	void Start () {
        //Debug.Log("Rotation Y: " + transform.rotation.y + "\nLocal Rotation Y: " + transform.localRotation.y);

        if(transform.rotation.y == 0) rb.velocity = new Vector2(speed, 0); // Works fine, but I want to get the bullet to shoot from the angle that Katt is slanted at.  
        else rb.velocity = new Vector2(-speed, 0);
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
}