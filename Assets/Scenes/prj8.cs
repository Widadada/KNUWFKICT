using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj8 : MonoBehaviour 
{
    public DigitalInput sensor8;
    public Renderer card_08_mux2;
    void Start()
    {
        card_08_mux2 = GameObject.Find("card_08_mux2").GetComponent<Renderer>();
        card_08_mux2.material.color = Color.red;
        sensor8 = GameObject.Find("sensor8").GetComponent<DigitalInput>();
    }
    
    
    void Update()
    {
        if (sensor8.Value)
        {
            if(card_08_mux2.material.color != Color.blue)
            {
                card_08_mux2.material.color = Color.blue;
            }
            else
            {
                card_08_mux2.material.color = Color.red;
            }
        }
    }
}