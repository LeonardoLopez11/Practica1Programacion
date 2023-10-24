using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo3 : MonoBehaviour
{
    public float tiempoEntreCambio = 5f;
    private float tiempoTranscurrido = 0f;
    private Vector3 direcci�nActual;
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
            
            CambiarDirecci�n();
            tiempoTranscurrido = 0f;
        }

        
        MoverEnemigo();
    }
    private void MoverEnemigo()
    {

        transform.Translate(Vector3.forward * velocidadInicio * Time.deltaTime);
    }
    private void CambiarDirecci�n()
    {
        
        float nuevaDirecci�nX = Random.Range(-1f, 1f); 
        float nuevaDirecci�nZ = Random.Range(-1f, 1f);

        
        direcci�nActual = new Vector3(nuevaDirecci�nX, 0f, nuevaDirecci�nZ).normalized;
    }


}
