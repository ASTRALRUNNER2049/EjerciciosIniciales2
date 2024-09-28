using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] private float dañoMin;
    [SerializeField] private float dañoMax;
    [SerializeField] private int capacidadTotal;
    [SerializeField] private bool esAutomatica;
    private int municionActual;

    void Start()
    {
        municionActual = capacidadTotal;
    }

    public float UtilizarArma()
    {
        if (municionActual > 0)
        {
            municionActual--;
            return 0;
        }
        else
        {
            return -1;
        }
    }

    public float RecargarArma()
    {
        if (municionActual < capacidadTotal)
        {
            municionActual = capacidadTotal;
            return 0;
        }
        else
        {
            return -1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
