using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{

    public float enemyHealth;
    public float maxHealth = 5;
   
    void Start()
    {
        enemyHealth = maxHealth;
    }

    public void TakeHit(float damage)
    {
        enemyHealth -= damage;

        if (enemyHealth <= 0)
        {
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
