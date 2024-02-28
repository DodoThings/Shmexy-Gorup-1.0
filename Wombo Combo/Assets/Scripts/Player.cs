using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;

    public HealthBar healthBar;

    void Start()
    {

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
            Debug.Log("Player");
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }



}
