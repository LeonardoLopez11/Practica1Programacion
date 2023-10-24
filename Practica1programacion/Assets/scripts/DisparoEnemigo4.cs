using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo4 : MonoBehaviour
{
    public GameObject balaP; 
    public Transform OrigenDisparo; 
    public float areaDeVisiónInicial = 10;
    public float aumentoDeÁreaDeVisión = 2;

    private Transform player; 
    private bool playerdetectado = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Jugador").transform; 

    }

    // Update is called once per frame
    void Update()
    {
        
        if (!playerdetectado && Vector3.Distance(transform.position, player.position) <= areaDeVisiónInicial)
        {
            
            Disparar();
            playerdetectado = true;
        }

        
        areaDeVisiónInicial += aumentoDeÁreaDeVisión * Time.deltaTime;
    }
    private void Disparar()
    {
        
        GameObject bala = Instantiate(balaP, OrigenDisparo.position, OrigenDisparo.rotation);
        Rigidbody rb = bala.GetComponent<Rigidbody>();
        rb.velocity = (player.position - OrigenDisparo.position).normalized *10;
    }
}
