using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{

    int oro = 7;
    int oro1Minuto = 0, oro1Hora = 0, oro4Horas = 0;

   
    void Start()
    {
        oro1Minuto = oro * 60;
        Debug.Log("7 por segundos son " + oro1Minuto);
        oro1Hora = oro1Minuto * 60;
        oro4Horas = oro1Hora + 4;

        Debug.Log("En 4 Horas tienes " + oro4Horas);
    }

   
}
