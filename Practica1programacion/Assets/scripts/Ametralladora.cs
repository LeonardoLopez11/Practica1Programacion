using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ametralladora : MonoBehaviour
{
    public Municion balasAmetralladora;

    public int daño = 3;
    public float cadenciaDeDisparo = 0;
    public int municion = 100;
    public Transform puntoDeDisparo; 
    public GameObject balas; 
    private float tiempoSiguienteDisparo = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        balasAmetralladora = new Municion();
        balasAmetralladora.nombre = "balasAmetralladora";
        balasAmetralladora.cantidadI = 200;
        municion = balasAmetralladora.cantidadI;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > tiempoSiguienteDisparo)
        {
            Disparar();
            tiempoSiguienteDisparo = Time.time + cadenciaDeDisparo;
        }
    }
    void Disparar()
    {
        if (municion > 0)
        {
            
            Instantiate(balas, puntoDeDisparo.position, puntoDeDisparo.rotation);
            municion--; 
        }
    }
}
