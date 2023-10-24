using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo3 : MonoBehaviour
{
    public GameObject balaPrefab; 
    public Transform puntoDeDisparo; 
    public float velocidadInicial = 5f;
    public float aumentoDeVelocidad = 0.1f;
    public float tiempoEntreDisparos = 2f; 
    private float tiempoTranscurrido = 0f;

    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Jugador").transform; 

    }

    // Update is called once per frame
    void Update()
    {
        tiempoTranscurrido += Time.deltaTime;

        if (tiempoTranscurrido >= tiempoEntreDisparos)
        {
            
            DispararJugador();
            tiempoTranscurrido = 0f;
            tiempoEntreDisparos -= aumentoDeVelocidad;
            tiempoEntreDisparos = Mathf.Clamp(tiempoEntreDisparos, 0.5f, 5f); 
        }
    }
    private void DispararJugador()
    {
        
        Vector3 dirección = (player.position - transform.position).normalized;
        transform.rotation = Quaternion.LookRotation(dirección);

        
        GameObject bala = Instantiate(balaPrefab, puntoDeDisparo.position, puntoDeDisparo.rotation);
        Rigidbody rb = bala.GetComponent<Rigidbody>();
        rb.velocity = dirección * velocidadInicial;
    }
}
