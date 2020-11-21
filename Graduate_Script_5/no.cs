using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class no : MonoBehaviour
{
    public GameObject noo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void click()
    {
        GameObject.Find("sssound").GetComponent<AudioSource>().Play();
        noo.SetActive(false);
    }
}
