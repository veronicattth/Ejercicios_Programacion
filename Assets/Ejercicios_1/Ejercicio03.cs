using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    public class Ejercicio03 : MonoBehaviour
    {
        
        // Start is called before the first frame update
        public void Start()
        {
            
            GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubo.transform.localScale = new Vector3(2, 2, 2); 

        }

    }
}

