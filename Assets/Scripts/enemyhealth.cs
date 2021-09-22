using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class enemyhealth : MonoBehaviour
{

    public float enemyHealth;
    public float maxHealth = 5;
    private Image healthBar;
   
    void Start()
    {
        enemyHealth = maxHealth;
    }

    public void TakeHit(float damage)
    {
        enemyHealth -= damage;


        if (gameObject.tag == "boss")
        {
            healthBar = GameObject.Find("Blood").GetComponent<Image>();
            healthBar.fillAmount = enemyHealth / maxHealth;
        }

        if (enemyHealth <= 0)
        {
            if (gameObject.tag == "boss")
            {
                LevelMsg.isBossAlive = 0;
            }
            Destroy(gameObject);
            ReduceEnemyNum();
        }
    }



    private void ReduceEnemyNum()
    {
        GameObject.Find("enemyspawner").GetComponent<enemyspawner>().enemyNumber --;

        GameObject killedAccount = GameObject.Find("KilledAccountValue");
        int killedAccountNum = int.Parse(killedAccount.GetComponent<UnityEngine.UI.Text>().text.ToString());
        killedAccountNum += 1;
        killedAccount.GetComponent<UnityEngine.UI.Text>().text = killedAccountNum.ToString();
    }
}
