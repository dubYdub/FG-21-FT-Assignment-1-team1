using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_ai : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float movespeed = 5f;

     void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle -90f;
        direction.Normalize();
        movement = direction;

       
        }
    private void FixedUptade()
    {
        moveCharacter(movement);

    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * movespeed * Time.deltaTime));

    }

        

    

}
