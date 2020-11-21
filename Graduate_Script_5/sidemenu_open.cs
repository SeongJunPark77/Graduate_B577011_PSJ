using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidemenu_open : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click()
    {
        GameObject.Find("sssound").GetComponent<AudioSource>().Play();
        menu.SetActive(true);
    }
}
