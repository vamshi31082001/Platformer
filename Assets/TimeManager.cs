using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    float time = 10.0f;
    public Text timeDisplay;
    
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timeDisplay.text = Mathf.RoundToInt(time).ToString();
       
    }
}
