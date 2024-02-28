using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHealth : MonoBehaviour
{
    public int enemyhealth = 20;


    public Slider enemySlider;

    public void SetEnemyMaxHealth(int enemyhealth)
    {
        enemySlider.maxValue = enemyhealth;
        enemySlider.value = enemyhealth;
    }


    public void SetEnemyHealth(int enemyhealth)
    {
        enemySlider.value = enemyhealth;
    }


}
