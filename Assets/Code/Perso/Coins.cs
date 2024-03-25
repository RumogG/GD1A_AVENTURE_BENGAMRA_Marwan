using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public static Coins instance;
    public int coinsCount;
    public Text coinsCountText;



    public void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance Coins");
            return;
        }
        instance = this;
    }

    public void AddCoins(int count)
    {
        coinsCount += count;
        UpdateTextUI();
    }

    public void RemoveCoins(int count)
    {
        coinsCount -= count;
        UpdateTextUI();
    }

    public void UpdateTextUI(){
        coinsCountText.text = coinsCount.ToString();
    }

}
