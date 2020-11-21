using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public GameObject archer;
    public GameObject wizard;
    public GameObject knight;
    public GameObject warlord;


    public static int aratk;
    public static int arskill;

    public static int wizatk;
    public static int wizskill;

    public static int kniatk;
    public static int kniskill;


    public static int waratk;
    public static int warskill;

    public static int icebombdamage;
    public static int snowraindamage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //archerhp Armp = GameObject.Find("archerhp").GetComponent<archerhp>();

        if(archerhp.archer_hp<=0)
        {
            SceneManager.LoadScene("04.Gameover");
        }

        //wizardhp Wizmp = GameObject.Find("wizardhp").GetComponent<wizardhp>();

        if (wizardhp.wizard_hp <= 0)
        {
            SceneManager.LoadScene("04.Gameover");
        }
        //warlordhp Warmp = GameObject.Find("warlordhp").GetComponent<warlordhp>();

        if (warlordhp.warlord_hp<= 0)
        {
            SceneManager.LoadScene("04.Gameover");
        }
        //knighthp Knimp = GameObject.Find("knighthp").GetComponent<knighthp>();

        if (knighthp.knight_hp <= 0)
        {
            SceneManager.LoadScene("04.Gameover");
        }
    }
}
