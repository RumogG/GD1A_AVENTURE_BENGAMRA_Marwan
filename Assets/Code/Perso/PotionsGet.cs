using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionsGet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Perso"))
        {
            Potions.instance.AddPotions(1);
            Destroy(gameObject);

        }
    }
}
