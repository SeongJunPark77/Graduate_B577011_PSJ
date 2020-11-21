using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutomp : MonoBehaviour
{
    public GameObject archer;
    public GameObject wizard;
    public GameObject knight;
    public GameObject warlord;

    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerEnter(Collider col)
    {
        //archermp Armp = GameObject.Find("archermp").GetComponent<archermp>();

        if (col.gameObject == archer)
        {
            GameObject.Find("potion_get_sound").GetComponent<AudioSource>().Play();
            archermp.archer_mp= archermp.archer_mp+10;
            wizardmp.wizard_mp = wizardmp.wizard_mp + 10;
            knightmp.knight_mp = knightmp.knight_mp + 10;
            warlordmp.warlord_mp = warlordmp.warlord_mp + 10;

            Destroy(gameObject);
        }

        //wizardmp Wzmp = GameObject.Find("wizardmp").GetComponent<wizardmp>();

        if (col.gameObject == wizard)
        {
            GameObject.Find("potion_get_sound").GetComponent<AudioSource>().Play();
            archermp.archer_mp = archermp.archer_mp + 10;
            wizardmp.wizard_mp = wizardmp.wizard_mp+10;
            knightmp.knight_mp = knightmp.knight_mp + 10;
            warlordmp.warlord_mp = warlordmp.warlord_mp + 10;

            Destroy(gameObject);
        }

        //knightmp Knimp = GameObject.Find("knightmp").GetComponent<knightmp>();

        if (col.gameObject == knight)
        {
            GameObject.Find("potion_get_sound").GetComponent<AudioSource>().Play();
            archermp.archer_mp = archermp.archer_mp + 10;
            wizardmp.wizard_mp = wizardmp.wizard_mp + 10;
            knightmp.knight_mp = knightmp.knight_mp + 10;
            warlordmp.warlord_mp = warlordmp.warlord_mp + 10;

            Destroy(gameObject);
        }
        //warlordmp Warmp = GameObject.Find("warlordmp").GetComponent<warlordmp>();

        if (col.gameObject == warlord)
        {
            GameObject.Find("potion_get_sound").GetComponent<AudioSource>().Play();
            archermp.archer_mp = archermp.archer_mp + 10;
            wizardmp.wizard_mp = wizardmp.wizard_mp + 10;
            knightmp.knight_mp = knightmp.knight_mp + 10;
            warlordmp.warlord_mp = warlordmp.warlord_mp+10;

            Destroy(gameObject);
        }

    }
}
