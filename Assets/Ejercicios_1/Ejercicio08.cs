using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    public class Ejercicio08 : MonoBehaviour
    {
        int cantidadCubos = 3;
        float crecimientoCubos = 2f;
        float separacionCubos = 10f;
       
        void Start()
        {
            for(int i = 1; i <= cantidadCubos; i++)
            {
                GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cubo.transform.position = new Vector3(i * separacionCubos, 0f, 0f);
                separacionCubos = separacionCubos + 1; //pongo esto para que no se amontonen pq al ir aumentando tamaño, se montan los objetos unos encima del otro
                                                       // se que no forma parte del ejercicio esto pero es para poder verlo yo visualmente en unity.
                cubo.transform.localScale = new Vector3(i * crecimientoCubos, i * crecimientoCubos, i * crecimientoCubos);
            }
        }

    }
}

