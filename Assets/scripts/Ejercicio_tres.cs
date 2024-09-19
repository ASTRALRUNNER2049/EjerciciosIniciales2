using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_tres : MonoBehaviour
{
    //EJ 3.1
    [SerializeField] private int numero1;
    [SerializeField] private int numero2;
    //EJ 3.2
    [SerializeField] private string nombre;
    //EJ 3.3
    [SerializeField] private int numero;
    private int doble;
    private int triple;
    //EJ 3.4
    [SerializeField] private float exp;
    private float level;
    //EJ 3.5
    [SerializeField] private float radio;
    private float longitud;
    private float area;
    private const float PI = Mathf.PI;
    //EJ 3.6
    [SerializeField] private float velocidadKmporh;
    private float velocidadMpors;
    //EJ 3.7
    [SerializeField] private float baseTriangulo;
    [SerializeField] private float alturaTriangulo;
    private float Areatriangulo;



    // Start is called before the first frame update
    void Start()
    {
        //EJ 3.1
        Debug.Log("El valor del primer número es: " + numero1);
        Debug.Log("El valor del segundo número es: " + numero2);
        //EJ 3.2
        Debug.Log("Bienvenido de nuevo, " + nombre);
        //EJ 3.3
        doble = numero * 2;
        triple = numero * 3;
        Debug.Log("El doble de " + numero + " es: " + doble);
        Debug.Log("El triple de " + numero + " es: " + triple);
        //EJ 3.4
        level = 32 + (9 * exp / 5);
        Debug.Log("El nivel del personaje es: " + level);
        //EJ 3.5
        longitud = 2 * PI * radio;
        area = PI * Mathf.Pow(radio, 2);
        Debug.Log("Longitud de la circunferencia es: " + longitud);
        Debug.Log("Área de la circunferencia es: " + area);
        //EJ 3.6
        velocidadMpors = velocidadKmporh * (1000f / 3600f);
        Debug.Log("Velocidad en metros por segundo: " + velocidadMpors);
        //EJ 3.7
        Areatriangulo = 0.5f * baseTriangulo * alturaTriangulo;
        Debug.Log("Área del triángulo: " + Areatriangulo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
