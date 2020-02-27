using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaArma : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bala, canoArma;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bala, canoArma.transform.position, canoArma.transform.rotation);
        }
    }
}
