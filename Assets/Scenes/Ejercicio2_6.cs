using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Ejercicio2_6 : MonoBehaviour
{


    int puntuacion1 = 3;
    int puntuacion2 = 3;
    int puntuacion3 = 3;

    int media;

    void Start()
    {
        media = (puntuacion1 + puntuacion2 + puntuacion3) / 3;

        Debug.Log(puntuacion1);
        Debug.Log(puntuacion2);
        Debug.Log(puntuacion3);

        Debug.Log(media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
