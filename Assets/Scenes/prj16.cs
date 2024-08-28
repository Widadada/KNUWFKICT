using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj16 : MonoBehaviour 
{
    public DigitalInput sensor16;
    public Renderer card_07_mux1;
    void Start()
    {
        card_07_mux1 = GameObject.Find("card_07_mux1").GetComponent<Renderer>();
        card_07_mux1.material.color = Color.yellow;
        sensor16 = GameObject.Find("sensor16").GetComponent<DigitalInput>();
    }
    
    
    void Update()
    {
        if (sensor16.Value)
        {
            if(card_07_mux1.material.color != Color.blue)
            {
                card_07_mux1.material.color = Color.blue;
            }
            else
            {
                card_07_mux1.material.color = Color.red;
            }
        }
    }
}