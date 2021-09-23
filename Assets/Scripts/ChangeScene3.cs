using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene3 : MonoBehaviour
{
    private int healthValue;
    private int killedValue;
    public int maxKilledNumber = 30;



    void Update()
    {


        healthValue = int.Parse(GameObject.Find("HealthValue").GetComponent<UnityEngine.UI.Text>().text);
        killedValue = int.Parse(GameObject.Find("KilledAccountValue").GetComponent<UnityEngine.UI.Text>().text);



        if (healthValue <= 0)
        {
            SceneManager.LoadScene("Endpage");

        }
        Debug.Log(LevelMsg.isBossAlive);

        if (LevelMsg.isBossAlive == 0)
        {
            SceneManager.LoadScene("level_credits");
            LevelMsg.currentLevel = 1;
            LevelMsg.isBossAlive = 1;

        }

    }
}
