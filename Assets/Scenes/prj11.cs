using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj11 : MonoBehaviour 
{
    public DigitalInput sensor11;
    public Renderer card_02_mux1;
    void Start()
    {
        card_02_mux1 = GameObject.Find("card_02_mux1").GetComponent<Renderer>();
        card_02_mux1.material.color = Color.yellow;
        sensor11 = GameObject.Find("sensor11").GetComponent<DigitalInput>();
    }
    
    
    void Update()
    {
        if (sensor11.Value)
        {
            if(card_02_mux1.material.color != Color.blue)
            {
                card_02_mux1.material.color = Color.blue;
            }
            else
            {
                card_02_mux1.material.color = Color.red;
            }
        }
    }
}