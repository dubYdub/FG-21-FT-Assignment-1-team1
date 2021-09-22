using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosshealth : MonoBehaviour
{
    public float enemyHealth;
    public int maxHealth = 5;
    public Healthbarscript healthBar;
    

    void Start()
    {
        enemyHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeHit(float damage)
    {
        enemyHealth -= damage;

        if (enemyHealth <= 0)
        {
            if (gameObject.tag == "boss")
            {
                LevelMsg.isBossAlive = 0;
            }
            Destroy(gameObject);
            ReduceEnemyNum();

            healthBar.SetMaxHealth(maxHealth);
        }
    }



    private void ReduceEnemyNum()
    {
        GameObject.Find("enemyspawner").GetComponent<enemyspawner>().enemyNumber--;

        GameObject killedAccount = GameObject.Find("KilledAccountValue");
        int killedAccountNum = int.Parse(killedAccount.GetComponent<UnityEngine.UI.Text>().text.ToString());
        killedAccountNum += 1;
        killedAccount.GetComponent<UnityEngine.UI.Text>().text = killedAccountNum.ToString();
    }
}
