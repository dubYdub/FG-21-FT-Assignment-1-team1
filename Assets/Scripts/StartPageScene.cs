using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPageScene : MonoBehaviour
{

    public void PlayScene()
    {
        
        SceneManager.LoadScene("level_"+LevelMsg.currentLevel.ToString());
    }

    public void TeamScene()
    {
        SceneManager.LoadScene("TeamScene");
    }

    public void RuleScene()
    {
        SceneManager.LoadScene("RuleScene");
    }

}
