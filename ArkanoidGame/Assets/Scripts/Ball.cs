using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;
    [SerializeField] float xPush;
    [SerializeField] float yPush;
    [SerializeField] Rigidbody2D rb;


    public Transform Paddle; //stores reference to the paddle
    Vector2 paddleToBallVector;
    public bool inPlay;
    public float speed;

    // Start is called before the first frame update
    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        if (!inPlay)
        {
            transform.position = Paddle.position;

        }

        LaunchToPaddle();

    }

    private void LaunchToPaddle()
    {
        if (Input.GetMouseButtonDown(0) && !inPlay)
        {
            inPlay = true;
            rb.simulated = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
            rb.AddForce(Vector2.up * speed);
        }
           
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Bottom"))
        {
            rb.velocity = Vector2.zero;
            inPlay = false;

        }
   
    
    
        
    }
    void OnCollisionEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("brick"))
        {
            Destroy (other.gameObject);
        }
    }
}


  
