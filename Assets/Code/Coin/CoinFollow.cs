using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFollow : MonoBehaviour
{
    public GameObject player;
    public float timeOffset;
    public Vector3 posOffset;
    private Vector3 velocity;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Perso"))
        {
            transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + posOffset, ref velocity, timeOffset);
        }
    }
}
