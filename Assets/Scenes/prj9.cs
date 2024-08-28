using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj9 : MonoBehaviour 
{
    public DigitalInput sensor9;
    public Renderer card_09_mux2;
    void Start()
    {
        card_09_mux2 = GameObject.Find("card_09_mux2").GetComponent<Renderer>();
        card_09_mux2.material.color = Color.red;
        sensor9 = GameObject.Find("sensor9").GetComponent<DigitalInput>();
    }
    
    
    void Update()
    {
        if (sensor9.Value)
        {
            if(card_09_mux2.material.color != Color.blue)
            {
                card_09_mux2.material.color = Color.blue;
            }
            else
            {
                card_09_mux2.material.color = Color.red;
            }
        }
    }
}