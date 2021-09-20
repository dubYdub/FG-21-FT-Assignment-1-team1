using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemyFollowing : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;

    private Rigidbody2D target;
    public Rigidbody2D rb;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 lookDir = target.position - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle + 90f;
        rb.position = Vector2.MoveTowards(rb.position, target.position, speed * Time.deltaTime);
    }
}
