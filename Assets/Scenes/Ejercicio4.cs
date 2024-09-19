using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{

    float basee, altura;
    void Start()
    {
        float resultadoCirculo = areaCirculo(7);
        Debug.Log(resultadoCirculo);
        float resultadoTriangulo = areaTriangulo(7,9);
        Debug.Log(resultadoTriangulo);
        float resultadoCuadrado = areaCuadrado(7);
        Debug.Log(resultadoCuadrado);


        string pFinal = construirNombre("leila", "martinez" , "sanchez" , "20");
        Debug.Log( " Hola me llamo " + pFinal);



        float cFinal = convertir(10, "euros");
        Debug.Log(cFinal);



        float vfinal = velocidad(50);
        Debug.Log(vfinal);
    }

    float areaCirculo( float radio)
    {

        float areaCirculo = (radio * radio) * 3.14f;
        return areaCirculo;

    }
    float areaTriangulo(float basee, float altura)
    {

        float areaTriangulo = (basee * altura) / 2;
        return areaTriangulo;

    }
    float areaCuadrado(float lado)
    {

        float areaCuadrado = lado * lado;
        return areaCuadrado;

    }

    string construirNombre( string nombre, string apellido1, string apellido2, string edad) 
    {

        string persona = nombre + apellido1 + apellido2 + edad;
        return persona;

    }


    float convertir (float cantidad, string monedas)
    {
        float convertidor = cantidad * 1.11f / 1;
        return convertidor;
    }


    float velocidad(float medida)
    {

        float resultado = medida * 1000 / 3600;
        return resultado;   

    }

}
