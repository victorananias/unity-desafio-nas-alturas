using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorJogoController : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;
    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        imagemGameOver.SetActive(true);
    }
}
