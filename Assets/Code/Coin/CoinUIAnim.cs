using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinUIAnim : MonoBehaviour
{

    public static CoinUIAnim instance;
    public Animator animator;

    public void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance CoinUIAnim");
            return;
        }
        instance = this;
    }

    public void CoinUIGet()
    {
        if (animator.GetBool("CoinsGain") == true) {
            animator.SetBool("CoinsGain", false);
            animator.SetTrigger("CoinsGainStop");
            animator.SetBool("CoinsGain", true);
        }
        else
        {
            animator.SetBool("CoinsGain", true);
        }
    }

    public void CoinUIStop()
    {
        animator.SetBool("CoinsGain", false);
        animator.SetTrigger("CoinsGainStop");

    }
}
