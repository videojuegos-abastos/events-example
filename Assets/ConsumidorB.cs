using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ConsumidorB : MonoBehaviour
{
    void Start()
    {
        // Me suscribo con la función Escala()

        Productor.miEvento.AddListener(Escala);
    }

    void Escala()
    {
        transform.localScale = Vector3.one * 2;
    }
}
