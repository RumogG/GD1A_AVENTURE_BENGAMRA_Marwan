using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAtk : MonoBehaviour
{
    public static BossAtk instance;
    public Animator animator;
    public float damage;
    private bool canAtk = false;
    private bool selfAtk = false;
    public void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance BossAtk");
            return;
        }
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Perso"))
        {
            canAtk = true;
        }

        if (collision.CompareTag("Boss"))
        {
            selfAtk = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Perso"))
        {
            canAtk = false;
        }

        if (collision.CompareTag("Boss"))
        {
            selfAtk = false;
        }
    }
    public void launchAtk()
    {
        gameObject.GetComponent<AtkFollow>().enabled = false;
        animator.SetBool("Atk", true);
    }

    public void Atk()
    {
        if (canAtk == true)
        {
            HealthBar.instance.TakeDamage(damage);
        }

        if (selfAtk == true)
        {
            HealthBarBoss.instance.TakeDamage(damage);
        }
    }



public void ReactiveAtk()
    {
        gameObject.GetComponent<AtkFollow>().enabled = true;
        animator.SetBool("Atk", false);
    }


}
