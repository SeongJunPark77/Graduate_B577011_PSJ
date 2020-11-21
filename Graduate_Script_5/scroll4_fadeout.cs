using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll4_fadeout : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scroll4_main;

    void Awake()
    {

        scroll4_main.SetActive(false);
    }

    // Start is called before the first frame update
    public void clicked()
    {
        GameObject.Find("exit_sound").GetComponent<AudioSource>().Play();
        scroll4_main.SetActive(true);
    }
}
