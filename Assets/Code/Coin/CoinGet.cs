using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Perso"))
        {
            Coins.instance.AddCoins(1);
            CoinUIAnim.instance.CoinUIGet();
            Destroy(gameObject);

        }
    }
}
