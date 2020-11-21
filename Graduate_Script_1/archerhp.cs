using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class archerhp : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Hpbar;

    public static float archer_hp;

    // Update is called once per frame

    void Update()
    {
        archerHP();


    }

    void archerHP()
    {


        Hpbar.fillAmount = archer_hp / 100f;


      
    }
}
