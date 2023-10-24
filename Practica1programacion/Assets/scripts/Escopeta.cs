using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escopeta : MonoBehaviour
{
    public Municion cartuchosT;
    
    public int daño = 5;
    public float cadenciaDeDisparo = 1.0f;
    public int municion = 10;
    public Transform puntoDeDisparo; 
    public GameObject cartuchos; 
    private float tiempoSiguienteDisparo = 0.0f;

// Start is called before the first frame update
void Start()
    {
        cartuchosT = new Municion();
        cartuchosT.nombre = "cartuchos";
        cartuchosT.cantidadI = 6;
        municion = cartuchosT.cantidadI;
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
            for (int i = 0; i < 3; i++) 
            {
                
                Quaternion rotaciónAleatoria = Quaternion.Euler(0, Random.Range(-10, 10), 0);
                Instantiate(cartuchos, puntoDeDisparo.position, puntoDeDisparo.rotation * rotaciónAleatoria);
            }
            municion--; 

        }
        else
        {
            Debug.Log("No tienes balas");
        }
    }
}
