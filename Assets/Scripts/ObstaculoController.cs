using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 5f;

    [SerializeField] 
    private float variacaoY;

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }

    private void Mover()
    {
        transform.Translate(Vector3.left * (velocidade * Time.deltaTime));
    }
}