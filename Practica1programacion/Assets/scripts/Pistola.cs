using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistola : MonoBehaviour
{
    public Municion balas;

    public int daño = 10;
    public float cadenciaDeDisparo = 0.5f;
    public int municion = 30;
    public Transform puntoDeDisparo; 
    public GameObject bala; 
    private float tiempoSiguienteDisparo = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        balas = new Municion();
        balas.nombre = "Balas";
        balas.cantidadI = 5;
        municion = balas.cantidadI;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > tiempoSiguienteDisparo)
        {
            Disparar();
            tiempoSiguienteDisparo = Time.time + cadenciaDeDisparo;
        }
    }
    void Disparar()
    {
        if (municion > 0)
        {
            
            Instantiate(bala, puntoDeDisparo.position, puntoDeDisparo.rotation);
            municion--; 
        }
        else
        {
            
        }
    }
}
