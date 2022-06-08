using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{

    public Transform controle;
    public float velocidade = 12f;

    void Start()
    {
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movimento = transform.right * x + transform.forward * z;

        if (Input.GetKeyDown("w"))
		{

        }
        
        
    }
}
