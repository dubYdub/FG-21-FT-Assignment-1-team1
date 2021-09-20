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

    Vector2 movement;
    Vector2 mousePos;
    internal static Vector3 position;
    private int healthValue;
    private int attackValue;
    private int killedValue;

    private void Start()
    {
        //gameOverText.SetActive(false);
        //restartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = playercam.ScreenToWorldPoint(Input.mousePosition);

        healthValue = int.Parse(GameObject.Find("HealthValue").GetComponent<UnityEngine.UI.Text>().text);
        attackValue = int.Parse(GameObject.Find("AttackValue").GetComponent<UnityEngine.UI.Text>().text);
        killedValue = int.Parse(GameObject.Find("KilledAccountValue").GetComponent<UnityEngine.UI.Text>().text);
        
        if (healthValue <= 0)
        {
            SceneManager.LoadScene("Endpage");
            
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
            GameObject healthValue = GameObject.Find("HealthValue");
            int healthValueNum = int.Parse(healthValue.GetComponent<UnityEngine.UI.Text>().text.ToString());
            healthValueNum -= 2;
            healthValue.GetComponent<UnityEngine.UI.Text>().text = healthValueNum.ToString();
        }
    }

}
