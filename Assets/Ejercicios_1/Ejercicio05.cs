using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Ejercicios_1
{
    public class Ejercicio05 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //GameObject ej05 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            
            for (int i= 0; i < 30; i++)
            {
                GameObject ej05 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            }
        }

    }

}
