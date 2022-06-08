using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacaogenerica : MonoBehaviour
{
    public Vector3 rotacao;
    public float velocidadegiro;

    void Update()
    {
        transform.Rotate(rotacao * velocidadegiro * Time.deltaTime);
    }
}
