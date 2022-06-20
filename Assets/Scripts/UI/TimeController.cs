using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeController : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] Text timeText;

    private float rest;
    private bool ready;
   
    private void Awake()
    {
        rest = (min * 60) + seg;
        ready = true;
    }

    void Update()
    {
        if(ready){
            rest -= Time.deltaTime;
            if(rest < 1){
                ready = false;
                GameManager.instance.GameOver();            
            }
            int tempMin = Mathf.FloorToInt(rest / 60);
            int tempSeg = Mathf.FloorToInt(rest % 60);
            timeText.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
        }

        
    }
}
