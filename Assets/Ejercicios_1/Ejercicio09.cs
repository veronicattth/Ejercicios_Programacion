using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Ejercicios_1
{
    public class Ejercicio09 : MonoBehaviour
    {
        int cantidadEsferas = 12;
        float crecimientoEsferas = 2f;
        float separacionEsferas = 5f;
        GameObject esfera;

        void Start()
        {
            for (int i = 1, x = 0; i <= cantidadEsferas && x <= cantidadEsferas; i++, x++)
            {
                esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esfera.transform.position = new Vector3(x * separacionEsferas, 0f, 0f);
                separacionEsferas = separacionEsferas + 1;
                esfera.transform.localScale = new Vector3(i * crecimientoEsferas, i * crecimientoEsferas, i * crecimientoEsferas);
            }

            
        }
             //for (int x = 0; x < cantidadEsferas; x++)
              //{

        //    esfera.transform.position = new Vector3(x * separacionEsferas, 0f, 0f);

        //}
    }
}

