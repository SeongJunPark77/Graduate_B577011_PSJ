using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witch_arrow_skill : MonoBehaviour
{
    public ParticleSystem summon;
    // Start is called before the first frame update
    public GameObject aboss;
    public GameObject bboss;
    public GameObject cboss;
    bool skilluse = true;

    void Start()
    {
        summon.gameObject.SetActive(false);
        this.transform.Translate(Vector3.forward * 0.6f);
    }

    // Update is called once per frame
    void Update()
    {
        if (archermp.archer_mp <= -1)
        {
            skilluse = false;
        }
        else if (archermp.archer_mp > -1)
        {
            skilluse = true;
        }
        //프레임마다 오브젝트를 로컬좌표상에서 앞으로 1의 힘만큼 날아가라
        if (skilluse)
        {
            transform.Translate(Vector3.forward * 0.6f);
        }
    }

    void OnTriggerEnter(Collider c)
    {
        Vector3 pos = c.GetComponent<Transform>().position;
        summon.transform.position = pos + new Vector3(0, 1, 0);

        //Damage aratk = GameObject.Find("Damage").GetComponent<Damage>();

        if (c.gameObject == aboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            witch_main Boss = GameObject.Find("Witch01").GetComponent<witch_main>();

            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            Destroy(gameObject);

            Boss.hp = Boss.hp - Damage.arskill;
        }

        if (c.gameObject == bboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            witch_creature witch = GameObject.Find("creature").GetComponent<witch_creature>();
            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            witch.hp = witch.hp - Damage.arskill;
        }

        if (c.gameObject == cboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            witch_creature2 witch2 = GameObject.Find("creature2").GetComponent<witch_creature2>();
            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            witch2.hp = witch2.hp - Damage.arskill;
        }

        Destroy(gameObject, 0.3f);
    }
}
