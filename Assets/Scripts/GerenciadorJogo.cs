using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorJogo : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOver;
    private Aviao jogador;
    private Pontuacao pontuacao;

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        gameOver.SetActive(true);
    }

    public void ReiniciarJogo()
    {
        Time.timeScale = 1;
        gameOver.SetActive(false);
        jogador.Reiniciar();
        pontuacao.Reiniciar();
        DestruirObstaculos();
    }

    private void Start()
    {
        jogador = GameObject.FindGameObjectWithTag("Jogador").GetComponent<Aviao>();
        pontuacao = GameObject.FindGameObjectWithTag("Pontuacao").GetComponent<Pontuacao>();
    }

    private void DestruirObstaculos()
    {
        Obstaculo[] obstaculos = FindObjectsOfType<Obstaculo>();

        foreach(var obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
