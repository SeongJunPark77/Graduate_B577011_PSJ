using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class godpoint : MonoBehaviour
{
    // Start is called before the first frame update
    public Image god;
    public static int god_point;
    void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        god.fillAmount = god_point / 10f;

        if(god_point>10)
        {
            god_point--;
        }
    }
}
