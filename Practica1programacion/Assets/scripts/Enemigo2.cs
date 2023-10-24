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
            
            CambiarDirección();
        }
    }
    private void MovimientoEnemigo()
    {
        
        transform.Translate(Vector3.forward * velocidadInicio * Time.deltaTime);
    }
    private void CambiarDirección()
    {
        float nuevaDirecciónX = Random.Range(-1, 1); 
        float nuevaDirecciónZ = Random.Range(-1, 1);
        Vector3 nuevaDirección = new Vector3(nuevaDirecciónX, 0, nuevaDirecciónZ).normalized;
        transform.rotation = Quaternion.LookRotation(nuevaDirección);
        tiempoTranscurrido = 0f;

    }
}
