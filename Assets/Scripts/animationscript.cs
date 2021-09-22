using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationscript : MonoBehaviour
{
    IEnumerator start()
    {
        yield return new WaitForSeconds(5f);
        GetComponent<Animator>().Play("explo");
    }
}
