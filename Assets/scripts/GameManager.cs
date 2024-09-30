using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Personaje personaje1;
    public Personaje personaje2;
    private bool Ejecutado = false;
    private bool turnoPersonaje1 = true;

    public void FinDeTurno(Personaje personaje)
    {
        if (turnoPersonaje1)
        {
            personaje1.miTurno = true;
            personaje2.miTurno = false;
        }
        else
        {
            personaje1.miTurno = false;
            personaje2.miTurno = true;
        }
        turnoPersonaje1 = !turnoPersonaje1;
    }


    void PrepararPersonajes()
    {
        if (!Ejecutado)
        {
            personaje1.SetNombre("Guerrero");
            personaje1.vida(1000);
            personaje1.Experiencia(5000);
            Debug.Log($"{personaje1.Nombre()} tiene nivel {personaje1.CalcularNivel()}");

            personaje2.SetNombre("Mago");
            personaje2.vida(800);
            personaje2.Experiencia(4500);
            Debug.Log($"{personaje2.Nombre()} tiene nivel {personaje2.CalcularNivel()}");

            Ejecutado = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PrepararPersonajes();
        }
    }
}
