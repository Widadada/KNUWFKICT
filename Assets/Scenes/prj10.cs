using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;
//using System.Threading;

public class prj10 : MonoBehaviour 
{
    public DigitalInput sensor10;
    public Renderer card_01_mux1;
    public DigitalInput sensor11;
    public Renderer card_02_mux1;

    int i=0;
    int arrsize=10;
    bool[] value;
    bool pre = false;
    void Start()
    {
        value = new bool[arrsize];
        card_01_mux1 = GameObject.Find("card_01_mux1").GetComponent<Renderer>();
        card_01_mux1.material.color = Color.red;
        sensor10 = GameObject.Find("sensor10").GetComponent<DigitalInput>();
        card_02_mux1 = GameObject.Find("card_02_mux1").GetComponent<Renderer>();
        card_02_mux1.material.color = Color.red;
        sensor11 = GameObject.Find("sensor11").GetComponent<DigitalInput>();
    }
    
    
    void Update()
    {
        if(sensor10.Value){
            
        }
        else if(sensor11.Value){

        }
        
    }
}