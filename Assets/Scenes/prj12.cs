using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj12 : MonoBehaviour 
{
    public DigitalInput sensor1;
    public DigitalInput sensor2;
    public DigitalInput sensor3;
    public DigitalInput sensor4;
    public DigitalInput sensor5;
    public DigitalInput sensor6;
    public DigitalInput sensor7;
    public DigitalInput sensor8;
    public DigitalInput sensor9;
    public DigitalInput sensor10;
    public DigitalInput sensor11;
    public DigitalInput sensor12;
    public DigitalInput sensor13;
    public DigitalInput sensor14;
    public DigitalInput sensor15;
    public DigitalInput sensor16;
    public DigitalInput sensor17;
    public DigitalInput sensor18;


    public Renderer card_01_mux1;
    public Renderer card_02_mux1;
    public Renderer card_03_mux1;
    public Renderer card_04_mux1;
    public Renderer card_05_mux1;
    public Renderer card_06_mux1;
    public Renderer card_07_mux1;
    public Renderer card_08_mux1;
    public Renderer card_09_mux1;
    public Renderer card_01_mux2;
    public Renderer card_02_mux2;
    public Renderer card_03_mux2;
    public Renderer card_04_mux2;
    public Renderer card_05_mux2;
    public Renderer card_06_mux2;
    public Renderer card_07_mux2;
    public Renderer card_08_mux2;
    public Renderer card_09_mux2;


    bool[] pre_val;
    bool cur_val;

    void Start()
    {
        pre_val = new bool[19];
        card_01_mux1 = GameObject.Find("card_01_mux1").GetComponent<Renderer>();
        card_01_mux1.material.color = Color.red;
        card_02_mux1 = GameObject.Find("card_02_mux1").GetComponent<Renderer>();
        card_02_mux1.material.color = Color.red;
        card_03_mux1 = GameObject.Find("card_03_mux1").GetComponent<Renderer>();
        card_03_mux1.material.color = Color.red;
        card_04_mux1 = GameObject.Find("card_04_mux1").GetComponent<Renderer>();
        card_04_mux1.material.color = Color.red;
        card_05_mux1 = GameObject.Find("card_05_mux1").GetComponent<Renderer>();
        card_05_mux1.material.color = Color.red;
        card_06_mux1 = GameObject.Find("card_06_mux1").GetComponent<Renderer>();
        card_06_mux1.material.color = Color.red;
        card_07_mux1 = GameObject.Find("card_07_mux1").GetComponent<Renderer>();
        card_07_mux1.material.color = Color.red;
        card_08_mux1 = GameObject.Find("card_08_mux1").GetComponent<Renderer>();
        card_08_mux1.material.color = Color.red;
        card_09_mux1 = GameObject.Find("card_09_mux1").GetComponent<Renderer>();
        card_09_mux1.material.color = Color.red;

        card_01_mux2 = GameObject.Find("card_01_mux2").GetComponent<Renderer>();
        card_01_mux2.material.color = Color.blue;
        card_02_mux2 = GameObject.Find("card_02_mux2").GetComponent<Renderer>();
        card_02_mux2.material.color = Color.blue;
        card_03_mux2 = GameObject.Find("card_03_mux2").GetComponent<Renderer>();
        card_03_mux2.material.color = Color.blue;
        card_04_mux2 = GameObject.Find("card_04_mux2").GetComponent<Renderer>();
        card_04_mux2.material.color = Color.blue;
        card_05_mux2 = GameObject.Find("card_05_mux2").GetComponent<Renderer>();
        card_05_mux2.material.color = Color.blue;
        card_06_mux2 = GameObject.Find("card_06_mux2").GetComponent<Renderer>();
        card_06_mux2.material.color = Color.blue;
        card_07_mux2 = GameObject.Find("card_07_mux2").GetComponent<Renderer>();
        card_07_mux2.material.color = Color.blue;
        card_08_mux2 = GameObject.Find("card_08_mux2").GetComponent<Renderer>();
        card_08_mux2.material.color = Color.blue;
        card_09_mux2 = GameObject.Find("card_09_mux2").GetComponent<Renderer>();
        card_09_mux2.material.color = Color.blue;

        sensor1 = GameObject.Find("sensor1").GetComponent<DigitalInput>();
        sensor2 = GameObject.Find("sensor2").GetComponent<DigitalInput>();
        sensor3 = GameObject.Find("sensor3").GetComponent<DigitalInput>();
        sensor4 = GameObject.Find("sensor4").GetComponent<DigitalInput>();
        sensor5 = GameObject.Find("sensor5").GetComponent<DigitalInput>();
        sensor6 = GameObject.Find("sensor6").GetComponent<DigitalInput>();
        sensor7 = GameObject.Find("sensor7").GetComponent<DigitalInput>();
        sensor8 = GameObject.Find("sensor8").GetComponent<DigitalInput>();
        sensor9 = GameObject.Find("sensor9").GetComponent<DigitalInput>();
        sensor10 = GameObject.Find("sensor10").GetComponent<DigitalInput>();
        sensor11 = GameObject.Find("sensor11").GetComponent<DigitalInput>();
        sensor12 = GameObject.Find("sensor12").GetComponent<DigitalInput>();
        sensor13 = GameObject.Find("sensor13").GetComponent<DigitalInput>();
        sensor14 = GameObject.Find("sensor14").GetComponent<DigitalInput>();
        sensor15 = GameObject.Find("sensor15").GetComponent<DigitalInput>();
        sensor16 = GameObject.Find("sensor16").GetComponent<DigitalInput>();
        sensor17 = GameObject.Find("sensor17").GetComponent<DigitalInput>();
        sensor18 = GameObject.Find("sensor18").GetComponent<DigitalInput>();
    }
    
    
    void Update()
    {     
        if (isPressed(sensor1, 1)){
            change_color(card_01_mux2);
        }
        if (isPressed(sensor2, 2)){
            change_color(card_02_mux2);
        }
        if (isPressed(sensor3, 3)){
            change_color(card_03_mux2);
        }
        if (isPressed(sensor4, 4)){
            change_color(card_04_mux2);
        }
        if (isPressed(sensor5, 5)){
            change_color(card_05_mux2);
        }
        if (isPressed(sensor6, 6)){
            change_color(card_06_mux2);
        }
        if (isPressed(sensor7, 7)){
            change_color(card_07_mux2);
        }
        if (isPressed(sensor8, 8)){
            change_color(card_08_mux2);
        }
        if (isPressed(sensor9, 9)){
            change_color(card_09_mux2);
        }
        if (isPressed(sensor10, 10)){
            change_color(card_01_mux1);
        }
        if (isPressed(sensor11, 11)){
            change_color(card_02_mux1);
        }
        if (isPressed(sensor12, 12)){
            change_color(card_03_mux1);
        }
        if (isPressed(sensor13, 13)){
            change_color(card_04_mux1);
        }
        if (isPressed(sensor14, 14)){
            change_color(card_05_mux1);
        }
        if (isPressed(sensor15, 15)){
            change_color(card_06_mux1);
        }
        if (isPressed(sensor16, 16)){
            change_color(card_07_mux1);
        }
        if (isPressed(sensor17, 17)){
            change_color(card_08_mux1);
        }
        if (isPressed(sensor18, 18)){
            change_color(card_09_mux1);
        }
    }

    bool isPressed(DigitalInput sensor, int index){
        bool cur_val = sensor.Value;
        if (!pre_val[index] && cur_val){
            pre_val[index] = cur_val;
            return true;
        }
        pre_val[index] = cur_val;
        return false;
    }

    void change_color(Renderer card){
        if(card.material.color != Color.blue){
            card.material.color = Color.blue;
        }
        else{
            card.material.color = Color.red;
        }
    }
}