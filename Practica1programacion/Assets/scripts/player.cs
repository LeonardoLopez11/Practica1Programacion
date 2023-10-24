using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int Vida { get; private set; }
    

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

    private GameObject proyectil;
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

        if (Input.GetButtonDown("Fire1")) 
        {
            DispararProyectil();
        }
    }
    void DispararProyectil()
    {

        GameObject proyectilI = Instantiate(proyectil, transform.position, transform.rotation);


        Proyectil Proyectil = proyectilI.GetComponent<Proyectil>();
        if (Proyectil != null)
        {
            Proyectil.direccion = transform.forward;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            Enemigo enemigo = other.GetComponent<Enemigo>();
            if (enemigo != null)
            {
                RecibirDaño(enemigo.Daño); // Reducir la vida del jugador
            }
        }
        else if (other.CompareTag("BalaEnemigo"))
        {
            BalaEnemigo bala = other.GetComponent<BalaEnemigo>();
            if (bala != null)
            {
                RecibirDaño(bala.Daño); // Reducir la vida del jugador
            }
        }
    }
}
