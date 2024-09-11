using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_I_I : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Hello World!");
        Debug.Log("Este es el primer juego de Aaron");
        Debug.Log("estoy aprendiendo C#");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame");

        //El update funciona de manera que cualquier cosa que este dentro de el se actualize cada frame, por eso el mensaje se repite cada frame.
    }
}
