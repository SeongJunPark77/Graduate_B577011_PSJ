using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class warlordhp : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Hpbar;

    public static float warlord_hp;


    // Update is called once per frame
    void Update()
    {
        archerHP();


    }

    void archerHP()
    {


        Hpbar.fillAmount = warlord_hp / 140f;


    }
}
