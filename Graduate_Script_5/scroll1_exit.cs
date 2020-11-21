using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scroll1_exit : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject scroll1_main;

    // Start is called before the first frame update
    public void clicked()
    {
        GameObject.Find("exit_sound").GetComponent<AudioSource>().Play();
        scroll1_main.SetActive(false);
    }

}
