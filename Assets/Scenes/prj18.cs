using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj18 : MonoBehaviour 
{
    public DigitalInput sensor18;
    public Renderer card_09_mux1;
    void Start()
    {
        card_09_mux1 = GameObject.Find("card_09_mux1").GetComponent<Renderer>();
        card_09_mux1.material.color = Color.yellow;
        sensor18 = GameObject.Find("sensor18").GetComponent<DigitalInput>();
    }
    
    
    void Update()
    {
        if (sensor18.Value)
        {
            if(card_09_mux1.material.color != Color.blue)
            {
                card_09_mux1.material.color = Color.blue;
            }
            else
            {
                card_09_mux1.material.color = Color.red;
            }
        }
    }
}