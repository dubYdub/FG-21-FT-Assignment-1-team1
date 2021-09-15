using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthcollider : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<enemyhealth>();
        if (enemy)
        {
            enemy.TakeHit(1);
        }

        Destroy(gameObject);
    }
}
