using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectspawner : MonoBehaviour
{
    public float timer = 1f;

    public GameObject itemtospawn;




    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            
            GameObject effect = Instantiate(itemtospawn, transform.position, Quaternion.identity);
        }

    }
}
