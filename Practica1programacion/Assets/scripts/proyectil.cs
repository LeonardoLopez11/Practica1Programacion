using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float velocidad = 10.0f;
    public Vector3 direccion;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);

    }
}
