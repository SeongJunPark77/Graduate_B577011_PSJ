using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class archergodhit : MonoBehaviour
{
    public GameObject aboss;

    // Update is called once per frame

    void Update()
    {
       
    }
    void OnTriggerStay(Collider c)
    {
        //Damage aratk = GameObject.Find("Damage").GetComponent<Damage>();

        if (c.gameObject == aboss)
        {
            boss Boss = GameObject.Find("SnowTiger").GetComponent<boss>();
            Destroy(gameObject,5f);
            Boss.hp=Boss.hp - Damage.icebombdamage;


        }
        Destroy(gameObject, 5f);
    }

   
}
