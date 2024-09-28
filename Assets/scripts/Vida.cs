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

    public float RecibirDa�o(float da�o)
    {
        if (da�o < 0)
        {
            return -1;
        }
        vidaActual -= da�o;
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
