using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//hartontw
namespace Ejercicios_1
{
    ///<summary>
    /// Crear un script que cambie el nombre de todos los GameObjects de la escena en base a un atributo definido en este
    /// </summary>    
    public class Ejercicio10 : MonoBehaviour
    {
        string renombrar = "Me llamo objeto";

        private void Start()
        {
            //BoxCollider[] boxes = GameObject.FindObjectsOfType<BoxCollider>();
            //BoxCollider box = gameObject.GetComponent<BoxCollider>();

            GameObject[] objetosJuego = GameObject.FindObjectsOfType<GameObject>();

            for(int x = 0; x < objetosJuego.Length; x++)
            {
             
                objetosJuego[x].name = renombrar; 
            }

        }
    }

}
