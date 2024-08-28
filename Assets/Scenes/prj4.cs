using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj4 : MonoBehaviour 
{
    public DigitalInput sensor4;
    public Renderer card_04_mux2;
    void Start()
    {
        card_04_mux2 = GameObject.Find("card_04_mux2").GetComponent<Renderer>();
        card_04_mux2.material.color = Color.red;
        sensor4 = GameObject.Find("sensor4").GetComponent<DigitalInput>();
    }
    
    
    void Update()
    {
        if (sensor4.Value)
        {
            if(card_04_mux2.material.color != Color.blue)
            {
                card_04_mux2.material.color = Color.blue;
            }
            else
            {
                card_04_mux2.material.color = Color.red;
            }
        }
    }
}