using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootingscript : MonoBehaviour
{
    public Transform pointoffire;
    public GameObject bulletprefab;

    public float bulletForce = 30f;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();

            void Shoot()
            {
                GameObject bullet = Instantiate(bulletprefab, pointoffire.position, pointoffire.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(pointoffire.up * bulletForce, ForceMode2D.Impulse);
                
                
            }
        }

    }
}
