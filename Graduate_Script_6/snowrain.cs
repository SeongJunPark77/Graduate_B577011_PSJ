using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowrain : MonoBehaviour
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
            boss Boss = GameObject.Find("SnowTiger").GetComponent<boss>();
            Destroy(gameObject, 6f);
            Boss.hp = Boss.hp - Damage.snowraindamage;


        }
        Destroy(gameObject, 6f);

    }
}
