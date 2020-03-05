using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogador : MonoBehaviour
{
    public float velocidade = 10f;
    public LayerMask mascaraChao;

    void Start()
    {
        
    }

    void Update()
    {
        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit impacto;
        Physics.Raycast(raio, out impacto, mascaraChao);
        Debug.Log(impacto.point);
        if (Physics.Raycast(raio, out impacto, mascaraChao))
        {
           
            Vector3 posicaoMiraJogador = impacto.point - transform.position;
            posicaoMiraJogador.y = 0;

            Quaternion novaRotacao = Quaternion.LookRotation(posicaoMiraJogador);
            GetComponent<Rigidbody>().MoveRotation(novaRotacao);
        }
        Debug.DrawRay(raio.origin, raio.direction * 100, Color.red);

        float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");

        Vector3 direcao = new Vector3(eixoX, 0, eixoZ);

        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position +
             (direcao * velocidade * Time.deltaTime));

        if (direcao != Vector3.zero)
        {
            GetComponent<Animator>().SetBool("Movendo", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Movendo", false);
        }
        

        
    }
}
