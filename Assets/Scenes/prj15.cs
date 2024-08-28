using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj15 : MonoBehaviour 
{
    int i=0;
    int arrsize=101;
    bool[] value;
    public DigitalInput sensor15;
    public Renderer card_06_mux1;
    
    void Start()
    {
        value = new bool[arrsize];
        card_06_mux1 = GameObject.Find("card_06_mux1").GetComponent<Renderer>();
        card_06_mux1.material.color = Color.red;
        sensor15 = GameObject.Find("sensor15").GetComponent<DigitalInput>();
    }
    
    
    void Update()
    {
    //     //Debug.Log("15 " + sensor15.Value + ", " + card_06_mux1.material.color);

    //     if (sensor15.Value)
    //     {
    //         if(card_06_mux1.material.color != Color.blue)
    //         {
    //             card_06_mux1.material.color = Color.blue;

    //         }
    //         else
    //         {
    //             card_06_mux1.material.color = Color.red;
    //         }

    //     }
        value[i]=sensor15.Value;
        if (i==arrsize-1){
            for (int j=1;j<arrsize;j++){
                //Debug.Log("sensor 15: " + j + " " + value[j] + " " + card_06_mux1.material.color);
                if (value[j-1]!=value[j] && value[j-1]==false){
                    if(card_06_mux1.material.color != Color.blue)
                    {
                      
                      card_06_mux1.material.color = Color.blue;
                    }
                    else
                    {
                        card_06_mux1.material.color = Color.red;
                    }
                }
            }
            value[0]=value[arrsize-1];
            i=-1;
        }
        i+=1;
    }
}