using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo1 : MonoBehaviour
{
    public int daño = 5;
    public float velocidadInicial = 2;
    private float velocidadActual;
    public float aumentoVelocidad = 1;
    // Start is called before the first frame update
    void Start()
    {
        velocidadActual = velocidadInicial;
    }

    // Update is called once per frame
    void Update()
    {
        MoverEnemigo();
    }
    private void MoverEnemigo()
    {
        
        transform.Translate(Vector3.left * velocidadActual * Time.deltaTime);

        
        if (transform.position.x < -10f) 
        {
            velocidadActual += aumentoVelocidad;
            velocidadActual = Mathf.Clamp(velocidadActual, 0, 10); 
            transform.position = new Vector3(10f, transform.position.y, transform.position.z);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador")) 
        {
            
            player player = other.GetComponent<player>(); 
            if (player != null)
            {
                player.RecibirDaño(daño);
            }
        }
    }
}
