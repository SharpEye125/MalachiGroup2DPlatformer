﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HelloWorld!");
        string name = "Ambrose";
        Debug.Log(name);
        int hp = 120;
        float critChance = 0.2f;
        bool canQuest = true;
        Vector3 position = new Vector3(1, 2, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
