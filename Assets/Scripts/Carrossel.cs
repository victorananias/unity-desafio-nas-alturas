using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour
{
    [SerializeField]
    private float velocidade;
    private Vector3 posicaoInicial;
    private float tamanhoImagem;

    private void Awake()
    {
        posicaoInicial = transform.position;
        tamanhoImagem = GetTamanhoImagem();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        var deslocamento = Mathf.Repeat(Time.time * velocidade, tamanhoImagem);
        transform.localPosition = posicaoInicial + Vector3.left * deslocamento;
    }

    private float GetTamanhoImagem()
    {
        var tamanhoRealImagem = GetComponent<SpriteRenderer>().size.x;
        var escalaImagem = transform.localScale.x;

        return tamanhoRealImagem * escalaImagem;
    }
}