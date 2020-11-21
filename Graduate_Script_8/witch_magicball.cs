using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witch_magicball : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem summon;
    public GameObject aboss;
    public GameObject bboss;
    public GameObject cboss;

    void Start()
    {
        summon.gameObject.SetActive(false);
        this.transform.Translate(Vector3.forward * 0.6f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 0.4f);
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

            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            Boss.hp = Boss.hp - Damage.wizatk;


        }

        if (c.gameObject == bboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            witch_creature witch = GameObject.Find("creature").GetComponent<witch_creature>();

            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
       
            witch.hp = witch.hp - Damage.wizatk;
        }

        if (c.gameObject == cboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            witch_creature2 witch2 = GameObject.Find("creature2").GetComponent<witch_creature2>();

            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            witch2.hp = witch2.hp - Damage.wizatk;
        }

        Destroy(gameObject, 0.3f);
    }
}
