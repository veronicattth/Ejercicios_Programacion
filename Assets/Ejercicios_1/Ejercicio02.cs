using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Ejercicios_1
{
    public class Ejercicio02 : MonoBehaviour
    {
        public void Start()
        {
            GameObject Ej02 = new GameObject("Ej02");
            Ej02.transform.position = new Vector3(111.1f, -5f, 4.5f); 
        }
    }
}

