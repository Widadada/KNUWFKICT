using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj1 : MonoBehaviour 
{
    public DigitalInput sensor1;
    public Renderer card_01_mux2;
    
    void Start()
    {
        card_01_mux2 = GameObject.Find("card_01_mux2").GetComponent<Renderer>();
        card_01_mux2.material.color = Color.red;
        sensor1 = GameObject.Find("sensor1").GetComponent<DigitalInput>();
    }
    
    void Update()
    {
        if (sensor1.Value)
        {
            if(card_01_mux2.material.color != Color.blue)
            {
                card_01_mux2.material.color = Color.blue;
            }
            else
            {
                card_01_mux2.material.color = Color.red;
            }

        }

    }
}