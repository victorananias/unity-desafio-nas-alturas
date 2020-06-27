using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstaculoController : MonoBehaviour
{
    [SerializeField] private float velocidade = 5f;

    [SerializeField] private float variacaoY;

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }

    // Update is called once per frame
    private void Update()
    {
        Mover();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destruir();
    }

    private void Mover()
    {
        transform.Translate(Vector3.left * (velocidade * Time.deltaTime));
    }

    public void Destruir()
    {
        Destroy(gameObject);
    }
}