using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApuntesWhile : MonoBehaviour
{


    [SerializeField] int vidas;
    // Start is called before the first frame update
    void Start()
    {                        
        while (vidas > 0) //Bucle (ciclo)
        {


            Debug.Log("Sigo Vivo!!!!!");
            vidas--;
        }

        
        for (int soldado = 0; soldado < 100; soldado++) 
        { 
        
           Debug.Log("soldado n " +  soldado);
        
        
        
        }







    }




























    // Update is called once per frame
    void Update()
    {
        
    }
}
