using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadScene()
    {
        if(LevelMsg.currentLevel == 1)
        {
            SceneManager.LoadScene("level_1");

        }
        else if (LevelMsg.currentLevel == 2) {
            SceneManager.LoadScene("level_2");
        }

        else if (LevelMsg.currentLevel == 3)
        {
            SceneManager.LoadScene("level_3");
        }
        else if (LevelMsg.currentLevel == 4)
        {
            SceneManager.LoadScene("level_4");
        }
        
    }
}
