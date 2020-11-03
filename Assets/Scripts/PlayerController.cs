﻿////////////////
//Name: Thomas Allen
//Script by: Ryan Scheppler
//Date: 10/19/2020
//Description: Basic 4 directional movement
////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 10;
    public float AngularSpeed = 10;
    Rigidbody2D myRb;

    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {

        Vector2 movement = new Vector2();

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //use the horizontal value to rotate can be add torque or just set the angular velocity

        myRb.AddTorque(-movement.x * AngularSpeed * Time.deltaTime);

        //set the forward and backward speeds
        myRb.AddForce(transform.up * movement.y * Speed * Time.deltaTime);

        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speed = 1500;
        }
        else
        {
            Speed = 500;
        }
       

    }
}
