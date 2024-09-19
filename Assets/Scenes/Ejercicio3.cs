using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{


    [SerializeField] int numero;
    [SerializeField] int numero2;
    [SerializeField] string nombre; //3.1 3.2


    [SerializeField] int numero3; //3.3
    int doble;
    int triple;

    void Start()
    {
        Debug.Log(numero);
        Debug.Log(numero2);
        Debug.Log("Bienvenido de nuevo" + nombre); //3.1 3.2

        doble = numero3 * 2;
        triple = numero3 * 3;

        Debug.Log(doble);
        Debug.Log(triple);

    }


}
