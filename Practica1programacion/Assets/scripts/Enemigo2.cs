using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : MonoBehaviour
{
    public float velocidadInicio = 2;
    public float aumentoVelocidad = 1;
    public float tiempoMovimiento = 34; 
    private float tiempoTranscurrido = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoTranscurrido += Time.deltaTime;

        if (tiempoTranscurrido < tiempoMovimiento)
        {
            // Mover en la dirección actual
            MovimientoEnemigo();
        }
        else
        {
            // Cambiar a una dirección aleatoria
            CambiarDirección();
        }
    }
    private void MovimientoEnemigo()
    {
        // Implementa el movimiento hacia adelante
        transform.Translate(Vector3.forward * velocidadInicio * Time.deltaTime);
    }
    private void CambiarDirección()
    {
        

    }
}
