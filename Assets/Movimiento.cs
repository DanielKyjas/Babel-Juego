using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class Movimiento : MonoBehaviour
{

    [SerializeField] private Transform[] puntosMovimiento;
    [SerializeField] private float velocidadMovimiento;
    private int siguientePlataforma = 1;
    private bool ordenPlataforms = true; 

    private SpriteRenderer spriteRend;
    private Rigidbody2D rb2d;


    void Start()
    {

        spriteRend = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>(); 

    }
    void Update()
    {
        if (ordenPlataforms && siguientePlataforma + 1 >= puntosMovimiento.Length)
        {
            ordenPlataforms = false;
        }
        if (!ordenPlataforms && siguientePlataforma <= 0)
        {
            ordenPlataforms = true;
        }
        if (Vector2.Distance(transform.position, puntosMovimiento[siguientePlataforma].position) < 0.1f)
        {
            if (ordenPlataforms)
            {
                siguientePlataforma += 1;
            }
            else
            {
                siguientePlataforma -= 1;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[siguientePlataforma].position , velocidadMovimiento * Time.deltaTime);

    
    }



}
