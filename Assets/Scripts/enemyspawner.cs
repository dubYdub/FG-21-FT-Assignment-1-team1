using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    Vector2 wheretospawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-20f, 20f);
            wheretospawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, wheretospawn, Quaternion.identity);
        }
    }
}
