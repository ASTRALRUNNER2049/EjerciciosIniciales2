using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    private string nombre;
    private float vida;
    private float experiencia;
    public Vida miSistemaDeVida;
    public KeyCode curarTecla;
    public KeyCode ataqueTecla;
    public KeyCode recargarTecla;
    public float ataque;
    public float velocidad;
    public Personaje objetivo;
    private bool miTurno;

    public float CalcularNivel()
    {
        return experiencia / 1000;
    }

    public void SetNombre(string v)
    {
        this.nombre = nombre;
    }

    public void Vida()
    {
        this.vida = vida;
        
    }

    public void Experiencia(int v)
    {
        this.experiencia = experiencia;
    }

    public string Nombre()
    {
        return nombre;
    }

    public float Vida()
    {
        return vida;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(curarTecla))
        {
            miSistemaDeVida.RecibirCura(50);
        }

        if (Input.GetKeyDown(ataqueTecla) && miTurno)
        {
            float resultado = Arma.UtilizarArma();
            if (resultado == 0)
            {
                enemigo.RecibirDaño(Random.Range(Arma.dañoMin, Arma.dañoMax));
            }
            else
            {
                Debug.Log("Reload!!!");
            }
        }

        if (Input.GetKeyDown(recargarTecla))
        {
            float resultado = Arma.RecargarArma();
            if (resultado == 0)
            {
                Debug.Log("Arma recargada.");
            }
            else
            {
                Debug.Log("Arma ya cargada.");
            }
        }
    }

    public void RellenarStats(float atq, float vel, float hp)
    {
        ataque = atq;
        velocidad = vel;
        vida = hp;
    }

    public void MarcarObjetivo(Personaje obj)
    {
        objetivo = obj;
    }

    public void Atacar()
    {
        if (objetivo != null && vida > 0)
        {
            objetivo.vida -= ataque;
            Debug.Log($"{this.gameObject.name} ha atacado a {objetivo.gameObject.name} causando {ataque} de daño. Vida restante del objetivo: {objetivo.vida}");

            if (objetivo.vida <= 0)
            {
                Debug.Log($"{objetivo.gameObject.name} ha sido derrotado!");
            }
        }
    }
}
