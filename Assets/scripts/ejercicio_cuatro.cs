using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_cuatro : MonoBehaviour
{
    // Start is called before the first frame update
    
    // EJ 4.1
    [SerializeField] private float radioCirculo;
    [SerializeField] private float ladoCuadrado;
    [SerializeField] private float baseTriangulo;
    [SerializeField] private float alturaTriangulo;
    // EJ 4.2
    [SerializeField] private string nombre;
    [SerializeField] private string apellido1;
    [SerializeField] private string apellido2;
    [SerializeField] private int edad;
    // EJ 4.3
    [SerializeField] private float cantidadEuros;
    [SerializeField] private string monedaDestino;
    // EJ 4.4
    [SerializeField] private float velocidadKmporh;
    private const float conversiondinero = 1.1f; 
    private const float PI = Mathf.PI;

    void Start()
    {
        // EJ 4.1
        Debug.Log("Área del círculo: " + CalcularCirculo(radioCirculo));
        Debug.Log("Área del cuadrado: " + CalcularCuadrado(ladoCuadrado));
        Debug.Log("Área del triángulo: " + CalcularTriangulo(baseTriangulo, alturaTriangulo));
        // EJ 4.2
        Debug.Log(ConstruirNombre(nombre, apellido1, apellido2, edad));
        // EJ 4.3
        Debug.Log("Cantidad convertida: " + Convertir(cantidadEuros, monedaDestino));
        // EJ 4.4
        Debug.Log("Velocidad en metros por segundo: " + ConvertirVelocidad(velocidadKmporh));
        // EJ 4.5
        float areaTriangulo = CalcularTriangulo(baseTriangulo, alturaTriangulo);
        Debug.Log("Conversión de área del triángulo a dólares: " + Convertir(areaTriangulo, "dólares"));
    }

    // EJ 4.1
    float CalcularCirculo(float radio)
    {
        return PI * Mathf.Pow(radio, 2);
    }

    float CalcularCuadrado(float lado)
    {
        return lado * lado;
    }

    float CalcularTriangulo(float baseTriangulo, float alturaTriangulo)
    {
        return 0.5f * baseTriangulo * alturaTriangulo;
    }
    // EJ 4.2 
    string ConstruirNombre(string nombre, string apellido1, string apellido2, int edad)
    {
        return $"La persona se llama {nombre} {apellido1} {apellido2} y tiene {edad} años";
    }
    // EJ 4.3 
    float Convertir(float cantidad, string moneda)
    {
        if (moneda.ToLower() == "dólares")
        {
            return cantidad * conversiondinero;
        }
        else if (moneda.ToLower() == "euros")
        {
            return cantidad / conversiondinero;
        }
        else
        {
            Debug.LogError("Moneda no reconocida. Usa 'dólares' o 'euros'.");
            return 0f;
        }
    }
    // EJ 4.4 
    float ConvertirVelocidad(float velocidadKmporh)
    {
        return velocidadKmporh * (1000f / 3600f);
    }
    // Update is called once per frame
    void Update()
    {

    }
}

