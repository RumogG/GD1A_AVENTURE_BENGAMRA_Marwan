using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBoss : MonoBehaviour
{
    public static HealthBarBoss instance;
    public Slider healthSlider;
    public Slider easeHealthSlider;
    public float maxHealth = 100f;
    public float health;
    private float lerpSpeed = 0.003f;
    public GameObject bar;

    public void Awake()
    {
        Off();
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance HealthBarBoss");
            return;
        }
        instance = this;
    }

    private void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        if(healthSlider.value != health)
        {
            healthSlider.value = health;
        }

        if (healthSlider.value != easeHealthSlider.value)
        {
            easeHealthSlider.value = Mathf.Lerp(easeHealthSlider.value, health, lerpSpeed);
        }

        if(health > maxHealth)
        {
            health = 100;
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }

    public void Regen(float hp)
    {
        health += hp;
    }

    public void On()
    {
        bar.SetActive(true);
    }

    public void Off()
    {
        bar.SetActive(false);
    }
}
