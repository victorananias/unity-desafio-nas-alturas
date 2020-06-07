using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AviaoController : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
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
        _rigidbody.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
    }
}