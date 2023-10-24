using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject proyectil;
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

        if (Input.GetButtonDown("Fire1")) // Cambia "Fire1" por el nombre de la entrada que desees
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
}
