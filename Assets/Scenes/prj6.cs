using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj6 : MonoBehaviour 
{
    public DigitalInput sensor6;
    public Renderer card_06_mux2;
    void Start()
    {
        card_06_mux2 = GameObject.Find("card_06_mux2").GetComponent<Renderer>();
        card_06_mux2.material.color = Color.red;
        sensor6 = GameObject.Find("sensor6").GetComponent<DigitalInput>();
    }
    
    
    void Update()
    {
        if (sensor6.Value)
        {
            if(card_06_mux2.material.color != Color.blue)
            {
                card_06_mux2.material.color = Color.blue;
            }
            else
            {
                card_06_mux2.material.color = Color.red;
            }
        }
    }
}