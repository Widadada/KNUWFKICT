using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj2 : MonoBehaviour 
{
    public DigitalInput sensor2;
    public Renderer card_02_mux2;
    void Start()
    {
        card_02_mux2 = GameObject.Find("card_02_mux2").GetComponent<Renderer>();
        card_02_mux2.material.color = Color.red;
        sensor2 = GameObject.Find("sensor2").GetComponent<DigitalInput>();

    }
    
    
    void Update()
    {
        if (sensor2.Value)
        {
            if(card_02_mux2.material.color != Color.blue)
            {
                card_02_mux2.material.color = Color.blue;
            }
            else
            {
                card_02_mux2.material.color = Color.red;
            }
        }
    }
}