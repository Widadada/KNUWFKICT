using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj13 : MonoBehaviour 
{
    public DigitalInput sensor13;
    public Renderer card_04_mux1;
    void Start()
    {
        card_04_mux1 = GameObject.Find("card_04_mux1").GetComponent<Renderer>();
        card_04_mux1.material.color = Color.yellow;
        sensor13 = GameObject.Find("sensor13").GetComponent<DigitalInput>();
    }
    
    
    void Update()
    {
        if (sensor13.Value)
        {
            if(card_04_mux1.material.color != Color.blue)
            {
                card_04_mux1.material.color = Color.blue;
            }
            else
            {
                card_04_mux1.material.color = Color.red;
            }
        }
    }
}