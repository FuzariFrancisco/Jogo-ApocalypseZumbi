using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaInimigo : MonoBehaviour
{
    public GameObject jogador;
    public float velocidade = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direcao = jogador.transform.position - transform.position;
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + direcao.normalized * velocidade * Time.deltaTime);
        Quaternion novaRotacao;
        novaRotacao = Quaternion.LookRotation(direcao);
        GetComponent<Rigidbody>().MoveRotation(novaRotacao);
    }
}
