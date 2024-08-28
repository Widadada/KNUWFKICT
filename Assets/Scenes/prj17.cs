using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj17 : MonoBehaviour 
{
    public DigitalInput sensor17;
    public Renderer card_08_mux1;
    void Start()
    {
        card_08_mux1 = GameObject.Find("card_08_mux1").GetComponent<Renderer>();
        card_08_mux1.material.color = Color.yellow;
        sensor17 = GameObject.Find("sensor8").GetComponent<DigitalInput>();
    }
    
    
    void Update()
    {
        if (sensor17.Value)
        {
            if(card_08_mux1.material.color != Color.blue)
            {
                card_08_mux1.material.color = Color.blue;
            }
            else
            {
                card_08_mux1.material.color = Color.red;
            }
        }
    }
}