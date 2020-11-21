using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aboss;
    bool skilluse = true;
    // Update is called once per frame
    public ParticleSystem summon;
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

        //Damage aratk = GameObject.Find("Damage").GetComponent<Damage>();

        if (c.gameObject == aboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            boss Boss = GameObject.Find("SnowTiger").GetComponent<boss>();

            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
          
                Boss.hp = Boss.hp - Damage.arskill;
        }

        Destroy(gameObject, 0.3f);
    }
}
