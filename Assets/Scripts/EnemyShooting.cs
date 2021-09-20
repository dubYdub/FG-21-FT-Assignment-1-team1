using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform pointoffire;
    public GameObject bulletprefab;
    public float coolDown = 1.5f;
    private float nextTime;

    public float bulletForce = 15f;

    private void Start()
    {
        nextTime = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTime)
        {
            Shoot();
            nextTime = Time.time + coolDown;
        } 

    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletprefab, pointoffire.position, pointoffire.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(pointoffire.up * bulletForce, ForceMode2D.Impulse);
    }
}
