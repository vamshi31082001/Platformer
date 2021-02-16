using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    float time = 10.0f;
    public Text timeDisplay;
    public GameObject gameoverpanel;
    // Start is called before the first frame update
    private void Awake()
    {
        gameoverpanel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timeDisplay.text = Mathf.RoundToInt(time).ToString();
        if (time <= 0)
        {
            gameoverpanel.SetActive(true);
        }
        
    }
}
