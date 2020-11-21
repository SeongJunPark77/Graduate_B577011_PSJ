using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss2_icebomb : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aboss;
    public GameObject bboss;

    // Update is called once per frame
    void Update()
    {


    }
    void OnTriggerStay(Collider c)
    {
        //Damage aratk = GameObject.Find("Damage").GetComponent<Damage>();
        boss2scri witch = GameObject.Find("boss2").GetComponent<boss2scri>();
        if (c.gameObject == aboss)
        {
            Destroy(gameObject, 5f);
            witch.hp = witch.hp - Damage.icebombdamage;


        }

        if (c.gameObject == bboss)
        {
            goblinscri Boss = GameObject.Find("goblin").GetComponent<goblinscri>();

            Destroy(gameObject, 5f);
            Boss.hp = Boss.hp - Damage.icebombdamage;


        }
        Destroy(gameObject, 5f);
    }
}
