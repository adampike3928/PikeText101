﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{//Allows us to acces a text compnenet
    [SerializeField] Text txtComponent;
    // Start is called before the first frame update
    void Start()
    {
        txtComponent.text = ("I am a program");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
