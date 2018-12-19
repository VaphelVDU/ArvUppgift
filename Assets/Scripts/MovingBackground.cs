﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    public float scalar = 1f;
    private Material mat;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        mat.SetTextureOffset("_MainTex", new Vector2(Time.time * scalar, 0));
    }
}
