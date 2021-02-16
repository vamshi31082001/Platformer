using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text coinstext;
    int coins = 0;
    public void ScoreIncreamnet(int value)
    {
        coins = coins + value;
        coinstext.text = "coins" + coins;
    }
}
