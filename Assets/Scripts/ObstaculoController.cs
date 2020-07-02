using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstaculoController : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 5f;
    [SerializeField]
    private float variacaoY;
    private Vector3 positionAviao;
    private PontuacaoController pontuacao;
    private bool pontuou = false;

    public void Destruir()
    {
        Destroy(gameObject);
    }

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }

    private void Start()
    {
        positionAviao = GameObject.FindGameObjectWithTag("Jogador").transform.position;
        pontuacao = GameObject.FindGameObjectWithTag("Pontuacao").GetComponent<PontuacaoController>();
    }

    // Update is called once per frame
    private void Update()
    {
        Mover();
        VerificarPonto();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destruir();
    }

    private void Mover()
    {
        transform.Translate(Vector3.left * (velocidade * Time.deltaTime));
    }

    private void VerificarPonto()
    {
        if (!pontuou && transform.position.x < positionAviao.x)
        {
            pontuou = true;
            pontuacao.AdicionarPontos();
        }
    }
}