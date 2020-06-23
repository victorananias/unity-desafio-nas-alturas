using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AviaoController : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    [SerializeField]
    private float forca = 10;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Impulsionar();
        }
    }

    private void Impulsionar()
    {
        rigidbody.velocity = Vector2.zero;
        rigidbody.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
    }
}