using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxmagic : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aboss;
    public GameObject bboss;
    public GameObject cboss;
    // Update is called once per frame
    public ParticleSystem summon;
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
        summon.transform.position = pos + new Vector3(0, 1, 0);
        Damage wizatk = GameObject.Find("Damage").GetComponent<Damage>();

        if (c.gameObject == aboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            boxman Boss = GameObject.Find("boxman").GetComponent<boxman>();
            Destroy(gameObject);
            Boss.hp--;


        }

        if (c.gameObject == bboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            boxman2 bBoss = GameObject.Find("BOXMAN2").GetComponent<boxman2>();
            Destroy(gameObject);

            if (bBoss.hp > 10)
            {
                bBoss.hp--;
            }

        }

        if (c.gameObject == cboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            goblin cBoss = GameObject.Find("Goblin").GetComponent<goblin>();

            Destroy(gameObject);

            cBoss.hp--;

        }

        Destroy(gameObject, 0.3f);
    }
}
