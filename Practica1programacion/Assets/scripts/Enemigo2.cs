using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : MonoBehaviour
{
    public float velocidadInicio = 2;
    public float aumentoVelocidad = 1;
    public float tiempoMovimiento = 3; 
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
            
            MovimientoEnemigo();
        }
        else
        {
            
            CambiarDirecci�n();
        }
    }
    private void MovimientoEnemigo()
    {
        
        transform.Translate(Vector3.forward * velocidadInicio * Time.deltaTime);
    }
    private void CambiarDirecci�n()
    {
        float nuevaDirecci�nX = Random.Range(-1, 1); 
        float nuevaDirecci�nZ = Random.Range(-1, 1);
        Vector3 nuevaDirecci�n = new Vector3(nuevaDirecci�nX, 0, nuevaDirecci�nZ).normalized;
        transform.rotation = Quaternion.LookRotation(nuevaDirecci�n);
        tiempoTranscurrido = 0f;

    }
}
