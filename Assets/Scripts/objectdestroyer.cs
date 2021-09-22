using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectdestroyer : MonoBehaviour
{
    public float timer = 1f;

    public GameObject objectdestroy;
    public GameObject bossexplosion;




    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Destroy(gameObject);
            GameObject effect = Instantiate(bossexplosion, transform.position, Quaternion.identity);
        }

    }
}
