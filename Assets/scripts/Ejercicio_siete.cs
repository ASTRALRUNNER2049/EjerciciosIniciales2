using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_siete : MonoBehaviour
{

   
    [SerializeField] private int numero;
    [SerializeField] private int num;
    [SerializeField] private int num1;
    [SerializeField] private int num2;

    void Start()
    {
        // EJ 7.1 
        int i = 1;
        while (i <= 100)
        {
            Debug.Log(i);
            i++;
        }

        // EJ 7.2 
        for (int j = 1; j <= 100; j++)
        {
            Debug.Log(j);
        }

        // EJ 7.3 
        i = 100;
        while (i >= 1)
        {
            Debug.Log(i);
            i--;
        }

        // EJ 7.4
        for (int j = 100; j >= 1; j--)
        {
            Debug.Log(j);
        }

        // EJ 7.5 
        i = 1;
        while (i <= numero)
        {
            Debug.Log(i);
            i++;
        }

       
        for (int j = 1; j <= numero; j++)
        {
            Debug.Log(j);
        }

        // EJ 7.6 
        i = num;
        while (i >= -num)
        {
            Debug.Log(i);
            i--;
        }

       
        for (int j = num; j >= -num; j--)
        {
            Debug.Log(j);
        }

        // EJ 7.7 
        int menor = Mathf.Min(num1, num2);
        int mayor = Mathf.Max(num1, num2);

        for (int j = menor; j <= mayor; j++)
        {
            Debug.Log(j);
        }

        // EJ 7.8 
        for (int j = menor; j <= mayor; j++)
        {
            if (j % 2 == 0)
            {
                Debug.Log(j + " es par.");
            }
        }

        // EJ 7.9 
        for (int j = 1; j <= num; j++)
        {
            if (j % 3 == 0)
            {
                Debug.Log(j + " es múltiplo de 3.");
            }
        }

        // EJ 7.10 
        for (int j = menor; j <= mayor; j++)
        {
            string signo = j >= 0 ? "positivo" : "negativo";
            string paridad = j % 2 == 0 ? "par" : "impar";
            Debug.Log(j + " es " + signo + " y " + paridad);
        }

        // EJ 7.11 
        TablaDeMultiplicar(num);

        // EJ 7.12
        int sumaTotal = SumarTodosLosNumeros(num1, num2);
        Debug.Log("La suma de todos los números entre " + num1 + " y " + num2 + " es: " + sumaTotal);

        // EJ 7.13 
        bool Primo = EsNumeroPrimo(num);
        Debug.Log(num + (Primo ? " es primo." : " no es primo."));
    }

    // EJ 7.11 
    void TablaDeMultiplicar(int numero)
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(numero + " x " + i + " = " + (numero * i));
        }
    }

    // EJ 7.12 
    int SumarTodosLosNumeros(int a, int b)
    {
        int menor = Mathf.Min(a, b);
        int mayor = Mathf.Max(a, b);
        int suma = 0;
        for (int i = menor; i <= mayor; i++)
        {
            suma += i;
        }
        return suma;
    }

    // EJ 7.13 
    bool EsNumeroPrimo(int numero)
    {
        if (numero < 2) return false;
        for (int i = 2; i <= Mathf.Sqrt(numero); i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }
    void Update()
    {

    }
}

