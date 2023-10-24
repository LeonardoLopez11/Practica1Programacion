using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int Vida = 50;
    

    public player(int vidaInicial)
    {
        Vida = vidaInicial;
    }

    public void RecibirDaño(int daño)
    {
        Vida -= daño;
        if (Vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    
    public float velocidad = 5;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);
        rb.velocity = movimiento * velocidad;

        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            Enemigo1 enemigo1 = other.GetComponent<Enemigo1>();
            if (enemigo1 != null)
            {
                RecibirDaño(enemigo1.daño); 
            }
        }
        
    }
}
