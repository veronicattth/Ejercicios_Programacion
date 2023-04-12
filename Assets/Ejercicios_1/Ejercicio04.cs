using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    public class Ejercicio04 : MonoBehaviour
    {
        // Start is called before the first frame update
        public void Start()
        {
            GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esfera.AddComponent<Rigidbody>();

        }

        
    }
}


