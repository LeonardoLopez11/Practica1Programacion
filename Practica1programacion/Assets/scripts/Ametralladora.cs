using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ametralladora : MonoBehaviour
{
    public int daño = 3;
    public float cadenciaDeDisparo = 0;
    public int munición = 100;
    public Transform puntoDeDisparo; 
    public GameObject balas; 
    private float tiempoSiguienteDisparo = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
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
        if (munición > 0)
        {
            
            Instantiate(balas, puntoDeDisparo.position, puntoDeDisparo.rotation);
            munición--; 
        }
    }
}
