using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timertolevelchange : MonoBehaviour
{
    public float timer = 10f;

    




    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            SceneManager.LoadScene("Credits_scene");

        }

    }
}
