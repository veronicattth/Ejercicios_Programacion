using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    ///<summary>
    /// Crear un script que genere 12 esferas cada una el doble de grande que la anterior
    /// </summary>    
    public class Ejercicio09 : MonoBehaviour
    {
        public int cantidadEsferas = 12;
        public float crecimientoEsferas = 2f;
        public float separacionEsferas = 5f;
        GameObject esfera;

        void Start()
        {
            /*for (int i = 1, x = 0; i <= cantidadEsferas && x <= cantidadEsferas; i++, x++)
            {
                esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esfera.transform.position = new Vector3(x * separacionEsferas, 0f, 0f);
                separacionEsferas = separacionEsferas + 1;
                esfera.transform.localScale = new Vector3(i * crecimientoEsferas, i * crecimientoEsferas, i * crecimientoEsferas);
            }*/

            //❕ 
            Ejercicio08.CrearFiguras(PrimitiveType.Sphere, cantidadEsferas, crecimientoEsferas, separacionEsferas);
        }
             //for (int x = 0; x < cantidadEsferas; x++)
              //{

        //    esfera.transform.position = new Vector3(x * separacionEsferas, 0f, 0f);

        //}
    }
}

