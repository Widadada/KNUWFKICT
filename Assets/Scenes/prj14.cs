using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class prj14 : MonoBehaviour 
{
    public DigitalInput sensor14;
    public Renderer card_05_mux1;
    void Start()
    {
        card_05_mux1 = GameObject.Find("card_05_mux1").GetComponent<Renderer>();
        card_05_mux1.material.color = Color.red;
        sensor14 = GameObject.Find("sensor14").GetComponent<DigitalInput>();
    }
    
    
    void Update()
    {
        //Debug.Log("14 " + sensor14.Value + ", " + card_05_mux1.material.color);
        if (sensor14.Value)
        {
            if(card_05_mux1.material.color != Color.blue)
            {
                card_05_mux1.material.color = Color.blue;
            }
            else
            {
                card_05_mux1.material.color = Color.red;
            }
            StartCoroutine(DelayCoroutine());    
        }
    }
    IEnumerator DelayCoroutine() {
                yield return new WaitForSeconds(2f);
            }
}