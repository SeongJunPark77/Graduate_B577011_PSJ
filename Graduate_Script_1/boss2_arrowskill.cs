using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss2_arrowskill : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject aboss;
    public GameObject barr;
    bool skilluse = true;

    public ParticleSystem summon;
    void Start()
    {
        summon.gameObject.SetActive(false);
        this.transform.Translate(Vector3.forward * 0.6f);
    }
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

    // Update is called once per frame
    void OnTriggerEnter(Collider c)
    {
        //Damage aratk = GameObject.Find("Damage").GetComponent<Damage>();
        Vector3 pos = c.GetComponent<Transform>().position;
        summon.transform.position = pos + new Vector3(0, 1, 0);
        if (c.gameObject == aboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            boss2scri witch = GameObject.Find("boss2").GetComponent<boss2scri>();
            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();

            Destroy(gameObject);
            witch.hp = witch.hp - Damage.arskill;

        }

        if (c.gameObject == barr)
        {
            Destroy(gameObject);
        }

        Destroy(gameObject, 0.3f);
    }
}
