using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentomouse : MonoBehaviour
{
    public float sensibilidade = 100f;
    public Transform jogador;

    float rotacaox = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mousex = Input.GetAxis("Mouse X") * sensibilidade * Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") * sensibilidade * Time.deltaTime;

        rotacaox -= mousey;
        rotacaox = Mathf.Clamp(rotacaox, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotacaox, 0f, 0f);
        jogador.Rotate(Vector3.up * mousex);
    }
}
