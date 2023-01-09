using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Necesitaremos este using para la clase UnityEvent !!
using UnityEngine.Events;

public class Productor : MonoBehaviour
{
    [SerializeField]
    // Hacemos el evento estático para que sea accesible más facilmente sin utilizar funciones Find()
    public static UnityEvent miEvento = new UnityEvent();


    void Update()
    {
        bool spacePressed = Input.GetKey(KeyCode.Space);

        if (spacePressed)
        {
            miEvento.Invoke();
        }
    }
}