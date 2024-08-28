using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemainTime : MonoBehaviour
{
    Text text;
    public static float rTime = 120f;
    void Start()
    {
        text = GetComponent<Text>();
        
    }

    void Update()
    {
        rTime -= Time.deltaTime;
        if(rTime<0) rTime=0;
        text.text = "Remain Time : " + Mathf.Round(rTime);
        
    }
}
