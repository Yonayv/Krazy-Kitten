using System;
using UnityEngine;
using System.Collections;

using System.Collections.Generic;
 
public class Enemy : MonoBehaviour

{

    public GameObject player;

    public float speed;

    public LayerMask groundLayer;

    private float distance;

    private bool isGrounded;

    private bool checkinGround;

    Rigidbody2D myRigidbody;

    BoxCollider2D myBoxCollider;

    public float jumpForce;

    private bool shouldJump;

     float jumpheight;

    [SerializeField] Vector2 boxsize;

    void Start()
    {
        
    }



     void Update()
    {
        if (player != null)
        {
            distance = Vector2.Distance(transform.position, player.transform.position);

            Vector2 direction = player.transform.position - transform.position;

            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

        }


    }

   
}

