using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoplayer : MonoBehaviour
{
    public float velocidade;
    public Transform orientacao;
    float controlehorizontal;
    float controlevertical;
    Vector3 direcao;
    Rigidbody rb;
    public float altura;
    public LayerMask oqueechao;
    bool nochao;
    public float dragpersonagem;

    public float forcaPulo;
    public float coolDownPulo;
    public float controleNoAr;
    double pulavel = 2;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void FixedUpdate()
    {
        Movimento();
    }

    private void Update()
    {
        Controles();

        nochao = Physics.Raycast(transform.position, Vector3.down, altura * 0.5f + 0.2f, oqueechao);

        if (nochao)
            rb.drag = dragpersonagem;
        else
            rb.drag = 0;

        if (nochao)
            pulavel = 1;
        
    }

    private void Controles()
    {
        controlehorizontal = Input.GetAxisRaw("Horizontal");
        controlevertical = Input.GetAxisRaw("Vertical");
        if(Input.GetKeyDown("space"))
        {
            if (pulavel > 0)
            {
                rb.AddForce(new Vector3(0f,forcaPulo,0f),ForceMode.Impulse);
                pulavel = pulavel-1;
            }
        }
            
            
    }

    private void Movimento()
    {
        direcao = orientacao.forward * controlevertical + orientacao.right * controlehorizontal;

        if(nochao)
            rb.AddForce(direcao.normalized * velocidade * 10f, ForceMode.Force);

        else if(!nochao)
            rb.AddForce(direcao.normalized * velocidade * 10f * controleNoAr, ForceMode.Force);

        if (ForceMode.Force>0)
        {
            ;
        }
             
    }

    private void ControleDeVelocidade()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if(flatVel.magnitude > velocidade);
        {
        Vector3 Limite = flatVel.normalized * velocidade;
        rb.velocity = new Vector3(Limite.x,rb.velocity.y,Limite.z);
        }
    }
}