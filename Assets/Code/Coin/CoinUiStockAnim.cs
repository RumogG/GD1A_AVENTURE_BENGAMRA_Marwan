using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinUIStockAnim : MonoBehaviour
{

    public static CoinUIStockAnim instance;
    public Animator animator;

    public void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance CoinUIStockAnim");
            return;
        }
        instance = this;
    }

    public void CoinUIStockGet()
    {
        if (animator.GetBool("CoinsStockGain") == true)
        {
            animator.SetBool("CoinsStockGain", false);
            animator.SetTrigger("CoinsStockGainStop");
            animator.SetBool("CoinsStockGain", true);
        }
        else
        {
            animator.SetBool("CoinsStockGain", true);
        }
    }

    public void CoinUIStockStop()
    {
        animator.SetBool("CoinsStockGain", false);
        animator.SetTrigger("CoinsStockGainStop");

    }
}
