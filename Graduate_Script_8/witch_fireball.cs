using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witch_fireball : MonoBehaviour
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
        if (wizardmp.wizard_mp <= -1)
        {
            skilluse = false;
        }
        else if (wizardmp.wizard_mp > -1)
        {
            skilluse = true;
        }

        if (skilluse)
        {
            //프레임마다 오브젝트를 로컬좌표상에서 앞으로 1의 힘만큼 날아가라
            transform.Translate(Vector3.forward * 0.3f);
        }
    }

    void OnTriggerEnter(Collider c)
    {
        Vector3 pos = c.GetComponent<Transform>().position;
        summon.transform.position = pos + new Vector3(0, 1, 0);
        //Damage wizatk = GameObject.Find("Damage").GetComponent<Damage>();

        if (c.gameObject == aboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            witch_main Boss = GameObject.Find("Witch01").GetComponent<witch_main>();

            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play(); ;
            Destroy(gameObject);
            for (int i = 0; i < 2; i++)
            {
                Boss.hp = Boss.hp - Damage.wizskill;
            }


        }

        if (c.gameObject == bboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            for (int i = 0; i < 2; i++)
            {
                witch_creature witch = GameObject.Find("creature").GetComponent<witch_creature>();
                witch.hp = witch.hp - Damage.wizskill;
            }
        }

        if (c.gameObject == cboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
                for (int i = 0; i < 2; i++)
                {
                witch_creature2 witch2 = GameObject.Find("creature2").GetComponent<witch_creature2>();
                witch2.hp = witch2.hp - Damage.wizskill;
                }
        }

        Destroy(gameObject, 0.3f);
    }
}
