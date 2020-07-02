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


    public void AdicionarPontos()
    {
        pontos++;
        AtualizarTexto();
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
