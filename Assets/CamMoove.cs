using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMoove : MonoBehaviour
{
    public Camera cam;
    public float timeOffset;

    private void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Perso"))
        {
            cam.transform.position = gameObject.transform.position;
        }
    }
}
