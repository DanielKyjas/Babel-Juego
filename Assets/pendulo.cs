using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class pendulo : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float limiteizq = 0.5f;
    public float limiteder = 0.5f;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.angularVelocity = 200;
    }

    // Update is called once per frame
    void Update()
    {
        swingMove();

    }
    void swingMove()
    {
        if(transform.rotation.z < limiteder && rb2d.angularVelocity > 0 && rb2d.angularVelocity < speed)
        {
            rb2d.angularVelocity = speed;
        }
        else if(transform.rotation.z > limiteizq && rb2d.angularVelocity < 0 && rb2d.angularVelocity > -speed)
        {
            rb2d.angularVelocity = -speed;
        }
    }
}
