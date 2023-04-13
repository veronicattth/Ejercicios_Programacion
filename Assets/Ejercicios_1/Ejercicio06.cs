using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    ///<summary>
    /// Crear un script que genere dos esferas al inicio separadas 100 metros
    ///</summary>    
    public class Ejercicio06 : MonoBehaviour
    {
        public float separacionEsferas = 100f;
        public int cantidadEsferas = 2;
        void Start()
        {
            //GameObject esfera1 = GameObject.CreatePrimitive(PrimitiveType.Sphere); 
            //GameObject esfera2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            //esfera1.transform.position = new Vector3(0f, 0f, 0f);
            //esfera2.transform.position = esfera2.transform.position + new Vector3(100f, 0f, 0f);

            for (int i = 0; i < cantidadEsferas; i++)
            {
                GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esfera.transform.position = new Vector3(i * separacionEsferas, 0f, 0f); 
            }
            
        }
        
            


    }
}

