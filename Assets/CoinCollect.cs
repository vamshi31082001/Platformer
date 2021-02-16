using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public ScoreManager oreManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
         oreManager.GetComponent<ScoreManager>().ScoreIncreamnet(1);
    }
}
