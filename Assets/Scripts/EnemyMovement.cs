using System;
using UnityEngine;
using System.Collections;

using System.Collections.Generic;
 
public class Enemy : MonoBehaviour

{

    public GameObject player;

    public float speed;

    public float jumpForce;

    public LayerMask groundLayer;

    private float distance;

    private bool isGrounded;

    private bool shouldJump;

    Rigidbody2D myRigidbody;

    BoxCollider2D myBoxCollider;

     void Start()
    {
        
    }

     void Update()
    {


        distance = Vector2.Distance(transform.position, player.transform.position);

        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

    }
}

