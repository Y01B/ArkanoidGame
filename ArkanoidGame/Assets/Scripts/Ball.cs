﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;

    Vector2 paddleToBallVector;

    // Start is called before the first frame update
    private void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.simulated = false;
    }

    // Update is called once per frame
   private void Update()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }
}
