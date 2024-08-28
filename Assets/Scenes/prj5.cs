using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj5 : MonoBehaviour 
{
    public DigitalInput sensor5;
    public Renderer card_05_mux2;
    void Start()
    {
        card_05_mux2 = GameObject.Find("card_05_mux2").GetComponent<Renderer>();
        card_05_mux2.material.color = Color.red;
        sensor5 = GameObject.Find("sensor5").GetComponent<DigitalInput>();
    }
    
    
    void Update()
    {
        if (sensor5.Value)
        {
            if(card_05_mux2.material.color != Color.blue)
            {
                card_05_mux2.material.color = Color.blue;
            }
            else
            {
                card_05_mux2.material.color = Color.red;
            }
        }
    }
}