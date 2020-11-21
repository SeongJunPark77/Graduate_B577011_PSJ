using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorimp : MonoBehaviour
{
    // Start is called before the first frame update
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
        int mp = 10;
        //archermp Armp = GameObject.Find("archermp").GetComponent<archermp>();

        if (col.gameObject == archer)
        {
            archermp.archer_mp= archermp.archer_mp+mp;

            Destroy(gameObject);
        }

        //wizardmp Wzmp = GameObject.Find("wizardmp").GetComponent<wizardmp>();

        if (col.gameObject == wizard)
        {
            wizardmp.wizard_mp= wizardmp.wizard_mp+mp;

            Destroy(gameObject);
        }

        //knightmp Knimp = GameObject.Find("knightmp").GetComponent<knightmp>();

        if (col.gameObject == knight)
        {
            knightmp.knight_mp= knightmp.knight_mp+mp;

            Destroy(gameObject);
        }
        //warlordmp Warmp = GameObject.Find("warlordmp").GetComponent<warlordmp>();

        if (col.gameObject == warlord)
        {
            warlordmp.warlord_mp= warlordmp.warlord_mp+mp;

            Destroy(gameObject);
        }

    }
}
