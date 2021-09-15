using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    public GameObject hitEffect;
    void OnCollisionEnter2D(Collision2D collision)
    { 
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.4f);
        Destroy(gameObject);
        Destroy(gameObject, 2f);

        var enemy = collision.collider.GetComponent<enemyhealth>();
        if (enemy)
        {
            enemy.TakeHit(1);
        }

        Destroy(gameObject);




    }

 
    }






