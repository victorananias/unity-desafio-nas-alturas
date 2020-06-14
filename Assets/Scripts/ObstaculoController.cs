using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 5f;

    // Update is called once per frame
    void Update()
    {
        Mover();
    }

    private void Mover()
    {
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
}