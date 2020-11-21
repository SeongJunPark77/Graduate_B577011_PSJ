using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll2_fadeout : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scroll2_main;

    void Awake()
    {

        scroll2_main.SetActive(false);
    }

    // Start is called before the first frame update
    public void clicked()
    {
        GameObject.Find("exit_sound").GetComponent<AudioSource>().Play();
        scroll2_main.SetActive(true);
    }
}
