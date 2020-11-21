using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicball : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aboss;
    public ParticleSystem summon;
    // Update is called once per frame

    void Start()
    {
        summon.gameObject.SetActive(false);
        this.transform.Translate(Vector3.forward * 0.6f);
    }


    void Update()
    {

        //프레임마다 오브젝트를 로컬좌표상에서 앞으로 1의 힘만큼 날아가라
        transform.Translate(Vector3.forward * 0.4f);

        


    }

    void OnTriggerEnter(Collider c)
    {
        Vector3 pos = c.GetComponent<Transform>().position;
        summon.transform.position = pos + new Vector3(0,1,0);
        //Damage wizatk = GameObject.Find("Damage").GetComponent<Damage>();

        if (c.gameObject == aboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            boss Boss = GameObject.Find("SnowTiger").GetComponent<boss>();

            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            Boss.hp = Boss.hp - Damage.wizatk;


        }

        Destroy(gameObject, 0.3f);
    }
}
