using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_open : MonoBehaviour
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

    public void Clicked()
    {
        menu.SetActive(true);
    }
}
