using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheat2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bigbro;
    public GameObject aaa;
    // Start is called before the first frame update

    public void click()
    {
        GameObject.Find("asdfqwer").GetComponent<AudioSource>().Play();
        bigbro.transform.position = aaa.transform.position;

    }
}
