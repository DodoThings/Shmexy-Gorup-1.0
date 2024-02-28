using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int enemyMaxHealth = 20;
    public int enemyCurrentHealth;

    public EnemyHealth enemyHealthBar;

    void Start()
    {

        enemyCurrentHealth = enemyMaxHealth;
        enemyHealthBar.SetEnemyMaxHealth(enemyMaxHealth);


    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TakeEnemyDamage(1);
            Debug.Log("Enemy");
        }
    }

    void TakeEnemyDamage(int damage)
    {
        enemyCurrentHealth -= damage;
        enemyHealthBar.SetEnemyHealth(enemyCurrentHealth);
    }

}
