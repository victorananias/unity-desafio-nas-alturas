using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorJogoController : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOver;
    private AviaoController jogador;
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
    }

    public void Start()
    {
        jogador = GameObject.FindGameObjectWithTag("Jogador").GetComponent<AviaoController>();
    }
}
