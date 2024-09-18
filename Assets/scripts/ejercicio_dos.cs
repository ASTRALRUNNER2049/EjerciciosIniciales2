using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ejercicio_dos : MonoBehaviour
{
    //int edad = 19;
    //int altura = 173;
    //string nombre = "Aaron" ;
    //int iva = 25;
    //int peso = 52; 
    //bool alumnorepetidor = false; 
    //char letra = 'A';
    //int minutos = 60;
    //string matriculacoche = "bof777";
    //bool mayordeEdad = false;
    //int codigopostal = 28690;
    //bool hombre = false;
    //bool mujer = false;
    //int numerodeHijos = 0;
    //int tallaCamisa = 34;
    //int precio = 2;
    //string mensaje = "xdn`t";
    //string mayordeedad = "si";
    //int dias = 365;
    //int contador = 0;
    //string tallacamisa = "S";

    
    int vidas = 3;            
    float exp = 4.5f;        
    char carac = 'A';
    int vidasPlayer1 = 11;
    int vidasPlayer2 = 22;
    int vidasPlayer3 = 33;
    int vidasPlayer4 = 44;

    int AUXvidasplayer2;

    float resultadoSuma;
    float resultadoResta;
    float resultadoMultiplicacion;
    float resultadoDivision;
    float resultadoPorcentaje;
    float Vidaspordos;
    float EXPportres;
    float Ej2coma4;
     // Cuando inicializamos una variable, podemos asignarle cierto valor, pero no podemos calcular el valor que le queremos asignar.



    // Start is called before the first frame update
    void Start()
    {
        // Las siguientes operaciones las realizamos dentro del método Start, porque Unity solo es capaz de hacerlas dentro de un método.
        resultadoSuma = vidas + exp;
        resultadoResta = exp - vidas;
        resultadoMultiplicacion = vidas * exp;
        resultadoDivision = vidas / exp;
        resultadoPorcentaje = vidas % exp;
        Vidaspordos = vidas * 2;
        EXPportres = exp * 3;
        Ej2coma4 = vidas + 77 -3 * 4;

        AUXvidasplayer2 = vidasPlayer2;
        vidasPlayer2 = vidasPlayer3;
        vidasPlayer3 = vidasPlayer1;
        vidasPlayer1 = vidasPlayer4;
        vidasPlayer4 = AUXvidasplayer2;
       

        Debug.Log("Vidas: " + vidas);
        Debug.Log("Experiencia: " + exp);
        Debug.Log("Resultado de la suma: " + resultadoSuma);
        Debug.Log("Resultado de la resta: " + resultadoResta);
        Debug.Log("Resultado de la multiplicacion: " + resultadoMultiplicacion);
        Debug.Log("Resultado de la Division: " + resultadoDivision);
        Debug.Log("Resultado del Porcentaje: " + resultadoPorcentaje);
        Debug.Log("Vidas por dos: " + Vidaspordos);
        Debug.Log("EXP por tres: " + EXPportres);
        Debug.Log("Ejercicio 2.4: " + Ej2coma4);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
