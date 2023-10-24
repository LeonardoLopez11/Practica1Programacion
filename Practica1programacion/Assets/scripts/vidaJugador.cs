using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaJugador : MonoBehaviour
{
    public int Vida { get; private set; }

    public vidaJugador(int vidaInicial)
    {
        Vida = vidaInicial;
    }

    public void RecibirDa�o(int da�o)
    {
        Vida -= da�o;
        if (Vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
