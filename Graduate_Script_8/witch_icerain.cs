using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witch_icerain : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aboss;
    public GameObject bboss;
    public GameObject cboss;
    // Update is called once per frame

    void Update()
    {

    }
    void OnTriggerStay(Collider c)
    {
        //Damage aratk = GameObject.Find("Damage").GetComponent<Damage>();

        if (c.gameObject == aboss)
        {
            witch_main Boss = GameObject.Find("Witch01").GetComponent<witch_main>();
            Destroy(gameObject, 6f);
            Boss.hp = Boss.hp - Damage.snowraindamage;
        }

        if (c.gameObject == bboss)
        {
            witch_creature witch = GameObject.Find("creature").GetComponent<witch_creature>();
            Destroy(gameObject, 6f);
            witch.hp = witch.hp - Damage.snowraindamage;
        }

        if (c.gameObject == cboss)
        {
            witch_creature2 witch2 = GameObject.Find("creature2").GetComponent<witch_creature2>();
            Destroy(gameObject, 6f);
            witch2.hp = witch2.hp - Damage.snowraindamage;
        }

        Destroy(gameObject, 6f);
    }
}
