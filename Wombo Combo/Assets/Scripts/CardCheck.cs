using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardCheck : MonoBehaviour
{
   

    public Slider slider;
    public HealthBar healthBar;
    public Player player;
    public int currentHealth;

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Punch")
        {
            TakeDamage(1);
            Debug.Log("punch");
        }
    }
    





    public void SetHealth(int health)
    {
        slider.value = health;
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

}
