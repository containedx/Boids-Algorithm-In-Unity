﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    public float speed;
    
    private void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

}
