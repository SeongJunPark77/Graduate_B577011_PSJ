using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class knighthp : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Hpbar;

    public static float knight_hp;


    // Update is called once per frame
    void Update()
    {
        archerHP();


    }

    void archerHP()
    {


        Hpbar.fillAmount = knight_hp / 350f;


    }
}
