using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{

    float vidaInicial = 120;
    float vidaActual = 120;

    float turno1 = 3;
    float turno2 = 6;
    float turno3 = 9;
    float turno4 = 12;
    float turno5 = 15;




    // Start is called before the first frame update
    void Start()
    {
        
        turno1 = vidaInicial *3 / 100;
        vidaActual = vidaActual - turno1;

        turno2 = vidaInicial * 6 / 100;
        vidaActual = vidaActual - turno2;



    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void DiasParaX()
    {
        int diasHasta= 0 ;

        if (diasHasta % 30 == 0)
        {

        }
    }
}


