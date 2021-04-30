using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTexture : MonoBehaviour
{
    public float Movex = 0.5f;
    public float Movey = 0.5f;

    void Update()
    {
        float OffsetX = Time.time * Movex;
        float OffsetY = Time.time * Movey;
        GetComponent<Renderer> ().material.mainTextureOffset = new Vector2(OffsetX, OffsetY);
    }
}
