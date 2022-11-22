using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    public BloodPool bloodPool;

    Vector2 movement;
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetActive();
        bloodPool.SetInactive();
    }

    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    TakeDamage(25);
        //}
        if(currentHealth <= 0)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    void FixedUpdate()
    {

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        healthBar.CheckActive(currentHealth);
        bloodPool.CheckActive(currentHealth);
    }
}
