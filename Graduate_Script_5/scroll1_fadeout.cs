using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll1_fadeout : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scroll1_main;



    void Awake()
    {
  

        scroll1_main.SetActive(false);
    }

    // Start is called before the first frame update
    public void clicked()
    {
        GameObject.Find("exit_sound").GetComponent<AudioSource>().Play();
        scroll1_main.SetActive(true);
    }
}
