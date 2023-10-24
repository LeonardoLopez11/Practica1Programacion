using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoCuarto : MonoBehaviour
{
    public float velocidadRotación = 30; 
    public Transform puntoCentral; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(puntoCentral.position, Vector3.up, velocidadRotación * Time.deltaTime);

    }
}
