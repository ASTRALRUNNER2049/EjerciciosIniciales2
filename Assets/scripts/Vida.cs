using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    [SerializeField] private float vidaInicial;
    private float vidaActual;

    void Start()
    {
        vidaActual = vidaInicial;
    }

    public float RecibirCura(float cantidad)
    {
        if (cantidad < 0)
        {
            return -1;
        }
        vidaActual += cantidad;
        return vidaActual;
    }

    public float RecibirDaño(float daño)
    {
        if (daño < 0)
        {
            return -1;
        }
        vidaActual -= daño;
        if (vidaActual <= 0)
        {
            vidaActual = 0;
            return 0;
        }
        return vidaActual;
    }

    void Update()
    {

    }
}
