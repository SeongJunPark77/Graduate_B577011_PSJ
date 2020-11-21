using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final_scroll : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject me;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void clicked()
    {
        GameObject.Find("exit_sound").GetComponent<AudioSource>().Play();
        me.SetActive(false);

    }
}
