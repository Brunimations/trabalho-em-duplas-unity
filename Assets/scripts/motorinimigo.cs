using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motorinimigo : MonoBehaviour
{
    Vector3 escalaatual;


    void Update()
    {
        if(escalaatual.y < 0.5)
        {
            escalaatual = transform.localScale;
            escalaatual.y += 0.1f;
        }
        if(escalaatual.y > 0.3)
        {
            escalaatual = transform.localScale;
            escalaatual.y -= 0.001f;
        }
        transform.localScale = escalaatual;
        
    }
}
