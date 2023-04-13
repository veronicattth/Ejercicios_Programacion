using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    ///<summary>
    /// Crear un script que genere tres cubos cada uno el doble de grande que el anterior
    ///</summary>    
    public class Ejercicio08 : MonoBehaviour
    {
        public int cantidadCubos = 3;
        public float crecimientoCubos = 2f;
        public float separacionCubos = 10f;
       
        void Start()
        {
            for(int i = 1; i <= cantidadCubos; i++)
            {
                GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cubo.transform.position = new Vector3(i * separacionCubos, 0f, 0f);
                separacionCubos = separacionCubos + 1; //pongo esto para que no se amontonen pq al ir aumentando tama�o, se montan los objetos unos encima del otro
                                                       // se que no forma parte del ejercicio esto pero es para poder verlo yo visualmente en unity.
                cubo.transform.localScale = new Vector3(i * crecimientoCubos, i * crecimientoCubos, i * crecimientoCubos);
            }
            //❕ CrearFiguras(PrimitiveType.Cube, cantidadCubos, crecimientoCubos, separacionCubos);
        }

        //❕
        public static void CrearFiguras(PrimitiveType figura, int cantidad, float crecimiento = 2f, float separacion = 0f)
        {
            float x = -0.5f; //Para que el primero se dibuje en (0, 0, 0)
            for (int i = 0; i < cantidad; i++)
            {
                GameObject cubo = GameObject.CreatePrimitive(figura);
                float size = Mathf.Pow(crecimiento, i); //1, 2, 4, 8, 16
                cubo.transform.localScale = Vector3.one * size;
                x += size/2f; //Empujamos el punto de creación la mitad del tamaño que tiene
                cubo.transform.position = new Vector3(x, 0f, 0f);
                x += size/2f; //Empujamos la otra mitad para retomar desde ahí en el próximo
                x += separacion; //Añadimos la separación que queremos entre cubos
            }
        }

    }
}

