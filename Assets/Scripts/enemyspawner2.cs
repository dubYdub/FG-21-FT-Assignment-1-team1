using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner2 : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    public GameObject enemy2;

    Vector2 wheretospawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    public int enemyNumber = 0;
    public int maxEnemyNumber = 4;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn && enemyNumber < maxEnemyNumber)
        {
            nextSpawn = Time.time + spawnRate;

            GameObject player = GameObject.Find("ship_2");

            randX = Random.Range(10f, 10f);
            wheretospawn = new Vector2(randX, transform.position.y);

            Instantiate(enemy, wheretospawn, Quaternion.identity);
            Instantiate(enemy2, wheretospawn, Quaternion.identity);

            enemyNumber = enemyNumber + 1;
        }
    }
}
