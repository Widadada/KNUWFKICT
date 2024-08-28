using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj3 : MonoBehaviour 
{
    public DigitalInput sensor3;
    public Renderer card_03_mux2;
    void Start()
    {
        card_03_mux2 = GameObject.Find("card_03_mux2").GetComponent<Renderer>();
        card_03_mux2.material.color = Color.red;
        sensor3 = GameObject.Find("sensor3").GetComponent<DigitalInput>();
    }
    
    
    void Update()
    {
        if (sensor3.Value)
        {
            if(card_03_mux2.material.color != Color.blue)
            {
                card_03_mux2.material.color = Color.blue;
            }
            else
            {
                card_03_mux2.material.color = Color.red;
            }
        }
    }
}