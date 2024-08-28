using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj7 : MonoBehaviour 
{
    public DigitalInput sensor7;
    public Renderer card_07_mux2;
    void Start()
    {
        card_07_mux2 = GameObject.Find("card_07_mux2").GetComponent<Renderer>();
        card_07_mux2.material.color = Color.red;
        sensor7 = GameObject.Find("sensor7").GetComponent<DigitalInput>();
    }
    
    
    void Update()
    {
        if (sensor7.Value)
        {
            if(card_07_mux2.material.color != Color.blue)
            {
                card_07_mux2.material.color = Color.blue;
            }
            else
            {
                card_07_mux2.material.color = Color.red;
            }
        }
    }
}