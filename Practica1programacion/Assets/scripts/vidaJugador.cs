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

    public void RecibirDaño(int daño)
    {
        Vida -= daño;
        if (Vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
