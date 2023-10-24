using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo3 : MonoBehaviour
{
    public float tiempoEntreCambio = 5f;
    private float tiempoTranscurrido = 0f;
    private Vector3 direcciónActual;
    public float velocidadInicio = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoTranscurrido += Time.deltaTime;

        if (tiempoTranscurrido >= tiempoEntreCambio)
        {
            
            CambiarDirección();
            tiempoTranscurrido = 0f;
        }

        
        MoverEnemigo();
    }
    private void MoverEnemigo()
    {

        transform.Translate(Vector3.forward * velocidadInicio * Time.deltaTime);
    }
    private void CambiarDirección()
    {
        
        float nuevaDirecciónX = Random.Range(-1f, 1f); 
        float nuevaDirecciónZ = Random.Range(-1f, 1f);

        
        direcciónActual = new Vector3(nuevaDirecciónX, 0f, nuevaDirecciónZ).normalized;
    }


}
