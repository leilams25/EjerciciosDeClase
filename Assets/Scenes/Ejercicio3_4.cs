using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    //3.4

    [SerializeField] int exp;

    int lvl;


    //3.5

    [SerializeField] int radio;
    double area, longitud;

    //3.6

    [SerializeField] int velocidad = 10;

    //3.7

    [SerializeField] float basee;
    [SerializeField] float altura;

    float area51;

    void Start()
    {
        lvl = 32 + (9 * exp / 5);
        Debug.Log(lvl);

        longitud = 2 * 3.14 * radio;
        area = 3.14 * Mathf.Pow (radio,2); // Para elevar al cuadrado??xd

        Debug.Log(longitud);
        Debug.Log(area);

       // velocidad = velocidad / (5 / 18);
       // Debug.Log(velocidad);                   Me da error en Unity

        area51 = basee * altura / 2;
        Debug.Log(area51);



    }



}
