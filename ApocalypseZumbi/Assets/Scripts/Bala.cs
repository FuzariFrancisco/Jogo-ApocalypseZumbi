using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidade = 50f;

    void Start()
    {
        
    }

    void Update()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.forward * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider objetoColidido)
    {
        if (objetoColidido.tag == "Inimigo")
        {
            Destroy(objetoColidido.gameObject); 
        }
        Destroy(gameObject);
    }
}
