using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio1_1 : MonoBehaviour
{
    string nombre = "Leila";
    int edad = 0;
    float altura = 0;
    float iva = 0;
    int peso = 0;
    bool alumnoRepetidor;
    char letra = 'A';
    int minutos = 0;
    string matriculaCoche;
    bool mayorDeEdad = false;
    int codigoPostal = 28840;
    bool numeroDeHijos = false;
    int tallaCamisa = 34;
    float precio = 27;
    string mensaje;
    int mayorEdad;
    int dias;
    int contador = 0;
    char tallaCamiseta = 'A';

    int vidas = 10;
    float exp = 10f;
    char carac = 'A';

    float resultadoSuma;
    float resultadoResta;

    float producto;
    float cociente;
    float resto;
    float doble;
    float triple;


    int vidasPlayer1 = 5;
    int vidasPlayer2 = 10;
    int vidasPlayer3 = 15;
    int vidasPlayer4 = 20;


    int puntuacion1 = 3;
    int puntuacion2 = 3;
    int puntuacion3 = 3;

    int media;


    int oro = 7;
    int oro1Minuto = 0, oro1Hora = 0, oro4Horas = 0;


    float vida28 = 120;
    double turno1 = 0, turno2 = 0, turno3 = 0, turno4 = 0;

    SerializeField velocidad;
    SerializeField vida;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Mundo!!, este es el primer video juego de " + nombre);
        Debug.Log("Estoy aprendiendo C#");

        Debug.Log(vidas);
        Debug.Log(exp);

        Debug.Log(resultadoResta);
        Debug.Log(resultadoSuma);

        
        

        resultadoSuma = vidas + exp; 
        resultadoResta = vidas - exp;

        producto = vidas * exp;
        cociente = vidas / exp;
        resto = vidas % exp;
        doble = vidas * 2;
        triple = exp * 3;

        vidas = vidas + 77;
        Debug.Log(vidas);

        vidas = vidas - 3; 
        Debug.Log(vidas);

        vidas = vidas * 4;
        Debug.Log(vidas);


        vidasPlayer2 = vidasPlayer3;
        vidasPlayer3 = vidasPlayer1;
        vidasPlayer1 = vidasPlayer4;
        vidasPlayer4 = vidasPlayer2;


        Debug.Log(vidasPlayer1);
        Debug.Log(vidasPlayer2);
        Debug.Log(vidasPlayer3);
        Debug.Log(vidasPlayer4);


        media = (puntuacion1 + puntuacion2 + puntuacion3) / 3;

        Debug.Log(puntuacion1);
        Debug.Log(puntuacion2);
        Debug.Log(puntuacion3);

        Debug.Log(media);


        Debug.Log(velocidad);


        
        oro1Minuto = oro * 60;
        Debug.Log("7 por segundos son " + oro1Minuto);
        oro1Hora = oro1Minuto * 60;
        oro4Horas = oro1Hora + 4; 

        Debug.Log("En 4 Horas tienes " + oro4Horas);

        ////////////////////////////////////////////////////////

        turno1 = vida28 * 3/ 100;
        turno1 = vida28 - turno1;   // esto tiene sentido???
        Debug.Log("AUUUU " + turno1 );






    }

    // Update is called once per frame











    void Update()
    {
        //Debug.Log("Ha pasado un frame"); //Aparece tantas veces en pantalla por que el update funciona con frames, 
    }                                   //por lo que el programa lee lo mismo cada frame ya que no hay nada que lo detenga.
}
