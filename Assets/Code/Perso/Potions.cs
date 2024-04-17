using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Potions : MonoBehaviour
{
    public static Potions instance;
    public int potionsCount = 4;
    public Text potionsCountText;



    public void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance Potions");
            return;
        }
        instance = this;
    }

    public void AddPotions(int count)
    {
        potionsCount += count;
        UpdateTextUI();
    }
    public void RemovePotions(int count)
    {
        if (potionsCount > 0)
        {
            potionsCount -= count;
        }
        UpdateTextUI();
    }

    public void UpdateTextUI(){
        potionsCountText.text = potionsCount.ToString();
    }

}
