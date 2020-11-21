using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll_mix : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scroll_final;
    public GameObject scroll1;
    public GameObject scroll2;
    public GameObject scroll3;
    public GameObject scroll4;
    public GameObject scroll5;

    void Awake()
    {
        scroll_final.SetActive(false);
    }
    void Update()
    {
       
    }
    // Start is called before the first frame update
    public void clicked()
    {
        scroll_final.SetActive(true);
        scroll1.SetActive(false);
        scroll2.SetActive(false);
        scroll3.SetActive(false);
        scroll4.SetActive(false);
        scroll5.SetActive(false);
    }
}
