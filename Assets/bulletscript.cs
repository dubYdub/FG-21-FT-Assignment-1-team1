using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    public GameObject hitEffect;
    void OnCollisionEnter2D(Collision2D collision)
    { 
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.7f);
        Destroy(gameObject);
        Destroy(gameObject, 2f);


        }
    }






