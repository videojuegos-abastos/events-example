using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Productor : MonoBehaviour
{
    [SerializeField]
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