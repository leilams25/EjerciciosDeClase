using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    string nombre = "Leila";

    
    void Start()
    {
        Debug.Log("Hola Mundo!!, este es el primer video juego de " + nombre);
        Debug.Log("Estoy aprendiendo C#");
    }

    






    void Update()
    {
        //Debug.Log("Ha pasado un frame"); //Aparece tantas veces en pantalla por que el update funciona con frames, 
    }                                   //por lo que el programa lee lo mismo cada frame ya que no hay nada que lo detenga.
}

