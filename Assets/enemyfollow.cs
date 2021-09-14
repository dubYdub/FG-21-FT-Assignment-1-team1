using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfollow : MonoBehaviour
{

   
    private Rigidbody2D rb;
    private Transform player;
   


    
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;

        
    }

    
}
