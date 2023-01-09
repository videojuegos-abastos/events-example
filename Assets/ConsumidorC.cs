using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ConsumidorC : MonoBehaviour
{
    void Start()
    {
        // Puedo suscibirme con tantas funciones como quiera
        Productor.miEvento.AddListener(CambiaColor);
        Productor.miEvento.AddListener(Escala);
    }

    void CambiaColor()
    {
        GetComponent<SpriteRenderer>().color = Color.green;
    }

    void Escala()
    {
        transform.localScale = Vector3.one * 2;
    }
}
