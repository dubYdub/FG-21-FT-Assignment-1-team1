using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public GameObject shootingEnemy;
    public GameObject stupidEnemy;
    float randX;

    Vector2 wheretospawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    public int enemyNumber = 0;
    public int maxEnemyNumber = 4;
    public float shootingEnemyratio = 0f;
    public float waittimer = 5f;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (waittimer >= 0)
        {
            waittimer = waittimer - Time.deltaTime;
            return;
        }
        if (Time.time > nextSpawn && enemyNumber < maxEnemyNumber)
        {
            nextSpawn = Time.time + spawnRate;

            GameObject player = GameObject.Find("ship_2");
           
            randX = Random.Range (-20f, 20f);
            wheretospawn = new Vector2(randX, transform.position.y);

            float seed = Random.Range(0f, 1.0f);

            if (seed > shootingEnemyratio)
            {
                Instantiate(stupidEnemy, wheretospawn, Quaternion.identity);
            }
            else
            {
                Instantiate(shootingEnemy, wheretospawn, Quaternion.identity);
            }


            enemyNumber = enemyNumber + 1; 
        }
    }
}
