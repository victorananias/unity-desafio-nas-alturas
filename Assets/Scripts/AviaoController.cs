using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AviaoController : MonoBehaviour
{
    [SerializeField]
    private float forca = 10;
    
    private Rigidbody2D rigidbody;
    private GerenciadorJogoController gerenciadorJogo;
    private Vector3 posicaoInicial;

    public void Reiniciar()
    {
        transform.position = posicaoInicial;
        AtivarFisica();
    }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        posicaoInicial = transform.position;
    }

    private void Start()
    {
        gerenciadorJogo = GameObject.FindGameObjectWithTag("GameController").GetComponent<GerenciadorJogoController>();
    }

    private void Update()
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        gerenciadorJogo.FinalizarJogo();
        PararFisica();
    }

    private void PararFisica()
    {
        rigidbody.simulated = false;
    }

    private void AtivarFisica()
    {
        rigidbody.simulated = true;
    }
}