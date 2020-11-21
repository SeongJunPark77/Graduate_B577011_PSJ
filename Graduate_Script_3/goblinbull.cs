using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goblinbull : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aboss;
    public GameObject barr;

    public ParticleSystem summon;
    void Start()
    {
        summon.gameObject.SetActive(false);
        this.transform.Translate(Vector3.forward * 0.6f);
    }
    void Update()
    {

        //프레임마다 오브젝트를 로컬좌표상에서 앞으로 1의 힘만큼 날아가라
        transform.Translate(Vector3.forward * 0.8f);



    }

    void OnTriggerEnter(Collider c)
    {
        //Damage aratk = GameObject.Find("Damage").GetComponent<Damage>();
        Vector3 pos = c.GetComponent<Transform>().position;
        summon.transform.position = pos + new Vector3(0, 1, 0);
        if (c.gameObject == aboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            boss2scri Boss = GameObject.Find("boss2").GetComponent<boss2scri>();

            Destroy(gameObject);
            Boss.hp = Boss.hp - Damage.aratk;



        }

        if (c.gameObject == barr)
        {
           
            Destroy(gameObject);
      



        }

        Destroy(gameObject, 0.3f);
    }
}
