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
    public GameObject hitEffect;
    public GameObject spawneffect;

    void Start()
    {
        enemyHealth = maxHealth;
        if (enemyHealth == maxHealth)
        {
            GameObject effect = Instantiate(spawneffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.6f);
        }
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
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.4f);
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
