using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ConsumidorA : MonoBehaviour
{
    void Start()
    {
        // Me suscribo con la función CambiaColor()

        Productor.miEvento.AddListener(CambiaColor);
    }

    void CambiaColor()
    {
        GetComponent<SpriteRenderer>().color = Color.blue;
    }
}
