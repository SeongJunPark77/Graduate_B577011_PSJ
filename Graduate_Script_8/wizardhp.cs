using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wizardhp : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Hpbar;

    public static float wizard_hp;


    // Update is called once per frame
    void Update()
    {
        archerHP();


    }

    void archerHP()
    {


        Hpbar.fillAmount = wizard_hp / 100f;


    }
}
