using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxmagicskill : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aboss;
    public GameObject bboss;
    public GameObject cboss;
    bool skilluse = true;
    public ParticleSystem summon;
    // Update is called once per frame
    void Start()
    {
        summon.gameObject.SetActive(false);
        this.transform.Translate(Vector3.forward * 0.6f);
    }



    void Update()
    {
        //wizardmp Wzmp = GameObject.Find("wizardmp").GetComponent<wizardmp>();

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
        Damage wizatk = GameObject.Find("Damage").GetComponent<Damage>();

        if (c.gameObject == aboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            boxman Boss = GameObject.Find("boxman").GetComponent<boxman>();
            Destroy(gameObject);

            for (int i = 0; i < 2; i++)
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
