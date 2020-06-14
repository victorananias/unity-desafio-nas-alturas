using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculosController : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerarObstaculo;
    [SerializeField]
    private GameObject obstaculo;
    private float cronometro;

    private void Awake()
    {
        cronometro = tempoParaGerarObstaculo;
    }

    void Update()
    {
        cronometro -= Time.deltaTime;

        if (cronometro >= 0)
        {
            return;
        }

        Instantiate(obstaculo, transform.position, Quaternion.identity);
        cronometro = tempoParaGerarObstaculo;
    }
}