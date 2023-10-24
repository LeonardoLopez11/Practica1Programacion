using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{
    public int da�o = 10;
    public GameObject balaP; 
    public Transform puntoDisparo; 
    public float velocidadI = 5;
    public float aumentoVelocidad = 1f;
    public float cadencia = 2;
    private float tiempoTranscurrido = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoTranscurrido += Time.deltaTime;

        if (tiempoTranscurrido >= cadencia)
        {
            
            Disparar();
            tiempoTranscurrido = 0f;
            cadencia -= aumentoVelocidad;
            cadencia = Mathf.Clamp(cadencia, 0.5f, 5f); 
        }
    }
    private void Disparar()
    {
    
        GameObject bala = Instantiate(balaP, puntoDisparo.position, puntoDisparo.rotation);
        Rigidbody rb = bala.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * velocidadI;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador")) 
        {
            
            player player = other.GetComponent<player>(); 
            if (player != null)
            {
                player.RecibirDa�o(da�o);
            }

            
            
        }
    }
}
