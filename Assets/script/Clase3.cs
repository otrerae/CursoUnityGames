using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Clase3 : MonoBehaviour
{    
    public int myLife = 100;
    public int Speed;
    public int Direction;
    public int Damage;
    public int Movement;
    public int Health;

    // Start is called before the first frame update
    void Start()
    {
       
        movimiento();        
        Dano(2);
        vida(100);
        danoRecibido(myLife);
    }
    // Update is called once per frame
    void Update()
    {




    }
    void movimiento()//Metodo para el movimiento del personaje
    {


    }

    void vida(int nivelVida)//metodo que muestra la vida del personaje
    {

        Debug.Log("El nivel actual de vida es: " + nivelVida);
        
    }

    void Dano(int cantidadDeDano)//metodo que mide el dano del personaje.
    {

        Debug.Log("La cantidad de dano es equivalente a: " + cantidadDeDano);

    }

    int danoRecibido(int danoRecibidoJugador)
    {

        danoRecibidoJugador -= 2;
        Debug.Log("el dano recibido es: " + danoRecibidoJugador);   
        return danoRecibidoJugador;
        

    }
}
