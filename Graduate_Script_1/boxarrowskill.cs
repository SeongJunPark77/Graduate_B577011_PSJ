using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxarrowskill : MonoBehaviour
{
    public GameObject aboss;
    public GameObject bboss;
    public GameObject cboss;
    public ParticleSystem summon;
    bool skilluse = true;
    // Update is called once per frame
    void Start()
    {
        summon.gameObject.SetActive(false);
        this.transform.Translate(Vector3.forward * 0.6f);
    }



    void Update()
    {
        //archermp Armp = GameObject.Find("archermp").GetComponent<archermp>();

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
        Damage aratk = GameObject.Find("Damage").GetComponent<Damage>();

        if (c.gameObject == aboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            boxman Boss = GameObject.Find("boxman").GetComponent<boxman>();
            Destroy(gameObject);

           for(int i = 0; i<2; i++)
            {
                Boss.hp--;
            }



        }

        if (c.gameObject == bboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            boxman2 bBoss = GameObject.Find("BOXMAN2").GetComponent<boxman2>();
            Destroy(gameObject);

           
                bBoss.hp = bBoss.hp-10;
            
        }

        if (c.gameObject == cboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            goblin cBoss = GameObject.Find("Goblin").GetComponent<goblin>();
            Destroy(gameObject);


            cBoss.hp = cBoss.hp - 10;

        }

        Destroy(gameObject, 0.3f);
    }
}
