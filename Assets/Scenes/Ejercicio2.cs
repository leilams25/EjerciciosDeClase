using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
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



    void Start()
    {
        resultadoSuma = vidas + exp;
        resultadoResta = vidas - exp;

        Debug.Log(vidas);
        Debug.Log(exp);

        Debug.Log(resultadoResta);
        Debug.Log(resultadoSuma);


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

    }


}
