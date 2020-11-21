using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll4_exit : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject scroll4_main;

    // Start is called before the first frame update
    public void clicked()
    {
        GameObject.Find("exit_sound").GetComponent<AudioSource>().Play();
        scroll4_main.SetActive(false);
    }
}
