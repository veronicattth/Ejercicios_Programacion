using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    ///<summary>
    /// Crear un script que genere tres esferas al inicio separadas 100 metros
    ///</summary>    
    public class Ejercicio07 : MonoBehaviour
    {
        int cantidadEsferas = 3;
        float separacionEsferas = 100f;
        
        void Start()
        {
            for (int i = 0; i < cantidadEsferas; i++)
            {
                GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esfera.transform.position = new Vector3(i * separacionEsferas, 0f, 0f);
            }

        }
    }

}
