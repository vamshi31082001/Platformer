using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WorldManager : MonoBehaviour
{
    int worldNo;
    public Text worldTextValue;
    // Start is called before the first frame update
    void Start()
    {
        worldNo = SceneManager.GetActiveScene().buildIndex;
        worldTextValue.text = (worldNo + 1).ToString();

        
    }

}
