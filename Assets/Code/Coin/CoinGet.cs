using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGet : MonoBehaviour
{
    public AudioSource audioCoin;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Perso"))
        {
            audioCoin.Play();
            Coins.instance.AddCoins(1);
            CoinUIAnim.instance.CoinUIGet();
            CoinUIStockAnim.instance.CoinUIStockGet();
            Destroy(gameObject);

        }
    }
}
