using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aim_tri : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aim;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)&&aim.activeSelf==true)
        {
            aim.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.R) && aim.activeSelf == false)
        {
            aim.SetActive(true);
        }
    }
}
