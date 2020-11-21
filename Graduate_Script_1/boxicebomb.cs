using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxicebomb : MonoBehaviour
{
    // Start is called before the first frame update
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
            goblin Boss = GameObject.Find("Goblin").GetComponent<goblin>();
            Destroy(gameObject, 5f);
            Boss.hp = Boss.hp - Damage.icebombdamage;


        }
        Destroy(gameObject, 5f);
    }
}
