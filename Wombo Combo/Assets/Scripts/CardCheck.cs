using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardCheck : MonoBehaviour
{
   

    public Slider slider;
    public HealthBar healthBar;
    public int currentHealth;

    private void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to 
        if (gameObject.tag == "Punch")
        {
            TakeDamage(1);
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
