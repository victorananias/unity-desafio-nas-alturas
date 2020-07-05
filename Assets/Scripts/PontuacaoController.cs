using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontuacaoController : MonoBehaviour
{
    [SerializeField]
    private Text textPontuacao;
    private int pontos;
    private AudioSource audio;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }


    public void AdicionarPontos()
    {
        pontos++;
        AtualizarTexto();
        audio.Play();
    }

    public void Reiniciar()
    {
        pontos = 0;
        AtualizarTexto();
    }

    private void AtualizarTexto()
    {
        textPontuacao.text = pontos.ToString("D4");
    }
}
