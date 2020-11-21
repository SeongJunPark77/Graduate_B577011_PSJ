using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golem_icerain : MonoBehaviour
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
            golem_main Boss = GameObject.Find("golem").GetComponent<golem_main>();
            Destroy(gameObject, 6f);
            Boss.hp = Boss.hp - Damage.snowraindamage;


        }
        Destroy(gameObject, 6f);

    }
}
