using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistola : MonoBehaviour
{
    public int da�o = 10;
    public float cadenciaDeDisparo = 0.5f;
    public int munici�n = 30;
    public Transform puntoDeDisparo; 
    public GameObject bala; 
    private float tiempoSiguienteDisparo = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
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
        if (munici�n > 0)
        {
            
            Instantiate(bala, puntoDeDisparo.position, puntoDeDisparo.rotation);
            munici�n--; 
        }
    }
}
