using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene4 : MonoBehaviour
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

        if (killedValue == maxKilledNumber)
        {
            SceneManager.LoadScene("Level_transitionboss");
            LevelMsg.currentLevel = 4;

        }




    }
}
    


