using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro : MonoBehaviour
{
    public Transform Visao;
    RaycastHit hit;
    void Update()
    {
        Ray raio = new Ray(Visao.position, Visao.forward);
        Physics.Raycast(raio, out hit);
        if(hit.transform == null)
        {
            return;
        }
        if(Input.GetButtonDown("Fire1") && hit.transform.gameObject.tag == "inimigo")
        {
            Destroy(hit.transform.gameObject);
        }
    }
}
