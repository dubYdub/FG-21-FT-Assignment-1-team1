using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStartScene : MonoBehaviour
{
    public void StartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
