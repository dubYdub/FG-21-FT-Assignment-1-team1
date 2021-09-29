using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Camera playercam;
    public GameObject gameOverText, restartButton;
    public GameObject takedamageEffect;
    public GameObject heartIcon;
    public GameObject particleEffect;
    public int heartShakingTime = 0;

    Vector2 movement;
    Vector2 mousePos;
    internal static Vector3 position;
    private int healthValue;
    private int attackValue;
    private int killedValue;

    private void Start()
    {
        heartIcon = GameObject.Find("HealthLogo");
        particleEffect = GameObject.Find("Particle_ship_rocket");
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.x == 0 && movement.y == 0)
        {
            particleEffect.active = false;
        } else
        {
            particleEffect.active = true;
        }


        mousePos = playercam.ScreenToWorldPoint(Input.mousePosition);

        healthValue = int.Parse(GameObject.Find("HealthValue").GetComponent<UnityEngine.UI.Text>().text);
        attackValue = int.Parse(GameObject.Find("AttackValue").GetComponent<UnityEngine.UI.Text>().text);
        killedValue = int.Parse(GameObject.Find("KilledAccountValue").GetComponent<UnityEngine.UI.Text>().text);
        
        if (healthValue <= 0)
        {
            SceneManager.LoadScene("Endpage");
            
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("StartScene");
        }

        if (heartShakingTime > 0)
        {
            float x = heartIcon.transform.position.x * Random.Range(.98f, 1.02f);
            float y = heartIcon.transform.position.y * Random.Range(.98f, 1.02f);
            float z = heartIcon.transform.position.z;

            heartIcon.transform.position = new Vector3(x, y, z);
            heartShakingTime --;
            GameObject.Find("HealthValue").GetComponent<UnityEngine.UI.Text>().color = Color.red;

        } else

        {
            GameObject killLogo = GameObject.Find("KillAccontLogo");
            float x = killLogo.transform.position.x - 2.5f;
            float y = killLogo.transform.position.y;
            float z = killLogo.transform.position.z;
            heartIcon.transform.position = new Vector3(x, y, z);
            GameObject.Find("HealthValue").GetComponent<UnityEngine.UI.Text>().color = Color.white;
        }

    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle -90f;
        
        

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "bullet" )
        {
            // health loss animation
            HealthLossAnima();
            // Hit effect for player
            GameObject effect = Instantiate(takedamageEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.4f);

        }
    }

    void HealthLossAnima()
    {
        GameObject healthValue = GameObject.Find("HealthValue");
        int healthValueNum = int.Parse(healthValue.GetComponent<UnityEngine.UI.Text>().text.ToString());
        heartShakingTime = 80;
        healthValueNum -= 2;
        healthValue.GetComponent<UnityEngine.UI.Text>().text = healthValueNum.ToString();
    }

}
