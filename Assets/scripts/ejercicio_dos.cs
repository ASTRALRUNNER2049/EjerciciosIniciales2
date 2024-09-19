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

    int puntuacion1 = 3;
    int puntuacion2 = 7;
    int puntuacion3 = 8;

    int AUXvidasplayer2;

    float resultadoSuma;
    float resultadoResta;
    float resultadoMultiplicacion;
    float resultadoDivision;
    float resultadoPorcentaje;
    float Vidaspordos;
    float EXPportres;
    float Ej2coma4;
    float resultadomediapuntuaciones;

    float oroPorSegundo = 7f;
    float horas = 4f;
    float segundosEnUnaHora = 3600f;
    float oroTotal;

    private float vidaInicial = 120f;
    private float porcentajeVeneno = 3f;
    private float vidaRestante;


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
        Ej2coma4 = vidas + 77 - 3 * 4;

        resultadomediapuntuaciones = puntuacion1 + puntuacion2 + puntuacion3 / 3;

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
        Debug.Log("Jugador 1 tiene todas estas vidas: " + vidasPlayer1);
        Debug.Log("Jugador 2 tiene todas estas vidas: " + AUXvidasplayer2);
        Debug.Log("Jugador 3 tiene todas estas vidas: " + vidasPlayer3);
        Debug.Log("Jugador 4 tiene todas estas vidas: " + vidasPlayer4);
        Debug.Log("El resultado de la media de las tres puntuaciones (3,7,8) es:  " + resultadomediapuntuaciones);

        oroTotal = oroPorSegundo * horas * segundosEnUnaHora;
        Debug.Log("Oro total farmeado en " + horas + " horas: " + oroTotal + " unidades.");

        vidaRestante = vidaInicial;

        for (int turno = 1; turno <= 5; turno++)
        {

            float dañoTurno = vidaInicial * (porcentajeVeneno / 100);
            vidaRestante -= dañoTurno;
            Debug.Log("Turno " + turno + ": Vida restante = " + vidaRestante + " unidades.");
            porcentajeVeneno += 3f;


        }

        // Update is called once per frame
        void Update()
        {

        }

    }

}
