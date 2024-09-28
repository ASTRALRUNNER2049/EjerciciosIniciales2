using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_cinco : MonoBehaviour
{
    // Start is called before the first frame update

    // EJ 5.1
    [SerializeField] private int vida1;
    [SerializeField] private int vida2;

    // EJ 5.2
    [SerializeField] private int numero1;
    [SerializeField] private int numero2;

    // EJ 5.3
    [SerializeField] private int numero;

    // EJ 5.4
    [SerializeField] private float dividendo;
    [SerializeField] private float divisor;

    // EJ 5.5
    [SerializeField] private int nivelPersonaje;

    // EJ 5.6
    [SerializeField] private int nivelPokemon;

    // EJ 5.7
    [SerializeField] private int velocidad1;
    [SerializeField] private int velocidad2;
    [SerializeField] private int velocidad3;

    // EJ 5.8
    [SerializeField] private int hora;
    [SerializeField] private int minutos;
    [SerializeField] private int segundos;

    // EJ 5.9
    [SerializeField] private int tipoEnemigo;

    // EJ 5.10
    [SerializeField] private float temperatura;

    void Start()
    {
        // EJ 5.1 
        if (vida1 == vida2)
        {
            Debug.Log("La batalla esta reñida: ambas vidas son iguales.");
        }
        else
        {
            Debug.Log("Las vidas son diferentes.");
        }

        // EJ 5.2 
        if (numero1 < 3 && numero2 < 3)
        {
            Debug.Log("Ambos numeros son menores a 3.");
        }
        else
        {
            Debug.Log("Uno o ambos numeros no son menores a 3.");
        }

        // EJ 5.3 
        if (numero >= 0 && numero <= 9)
        {
            Debug.Log("El numero esta entre 0 y 9.");
        }
        else
        {
            Debug.Log("El numero no esta entre 0 y 9.");
        }

        // EJ 5.4
        if (divisor != 0)
        {
            float resultadoDivision = dividendo / divisor;
            Debug.Log("El resultado de la division es: " + resultadoDivision);
        }
        else
        {
            Debug.LogError("Error: El divisor no puede ser cero.");
        }

        // EJ 5.5 
        if (nivelPersonaje % 2 == 0)
        {
            Debug.Log("El nivel es par.");
        }
        else
        {
            Debug.Log("El nivel es impar.");
        }

        // EJ 5.6 
        if (nivelPokemon % 10 == 0)
        {
            Debug.Log("El nivel es multiplo de 10.");
        }
        else
        {
            Debug.Log("El nivel no es multiplo de 10.");
        }

        // EJ 5.7 
        int mayorVelocidad = Mathf.Max(velocidad1, velocidad2, velocidad3);
        Debug.Log("La mayor velocidad es: " + mayorVelocidad);

        // EJ 5.8 
        if (hora >= 0 && hora < 24 && minutos >= 0 && minutos < 60 && segundos >= 0 && segundos < 60)
        {
            Debug.Log("La hora es valida: {hora:D2}:{minutos:D2}:{segundos:D2}");
        }
        else
        {
            Debug.LogError("La hora introducida no es valida.");
        }

        // EJ 5.9 
        switch (tipoEnemigo)
        {
            case 1:
                Debug.Log("Enemigo  1: pupa = 350, Vida = 650");
                break;
            case 2:
                Debug.Log("Enemigo  2: Pupa = 300, Vida = 550");
                break;
            case 3:
                Debug.Log("Enemigo  3: pupa = 300, Vida = 500");
                break;
            case 4:
                Debug.Log("Enemigo  4: Pupa = 310, Vida = 460");
                break;
            case 5:
                Debug.Log("Enemigo  5: pupa = 280, Vida = 490");
                break;
            case 6:
                Debug.Log("Enemigo  6: Pupa = 360, Vida = 520");
                break;
            default:
                Debug.LogError("Tipo de enemigo no válido.");
                break;
        }

        // EJ 5.10 
        if (temperatura <= 10)
        {
            Debug.Log("Clima: frio");
        }
        else if (temperatura > 10 && temperatura <= 20)
        {
            Debug.Log("Clima: Nublado");
        }
        else if (temperatura > 20 && temperatura <= 30)
        {
            Debug.Log("Clima: Caluroso");
        }
        else if (temperatura >= 30)
        {
            Debug.Log("Clima: Tropical");
        }
        
    }
}
