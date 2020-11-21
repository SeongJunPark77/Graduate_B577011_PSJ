using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golem_fire : MonoBehaviour
{
    public GameObject hall;
    public GameObject hall2;
    public GameObject hall3;
    public GameObject hall4;
    // Start is called before the first frame update
    public GameObject aboss;
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
        //Damage wizatk = GameObject.Find("Damage").GetComponent<Damage>();
      
            if (c.gameObject == aboss)
            {
                summon.gameObject.SetActive(true);
                summon.Play();
                GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
                golem_main gol = GameObject.Find("golem").GetComponent<golem_main>();
                Destroy(gameObject);
                if (hall.activeSelf == false && hall2.activeSelf == false && hall3.activeSelf == false && hall4.activeSelf == false)
                {
                    gol.hp = gol.hp - Damage.wizskill;

                }

            }
        

        if (c.gameObject == hall)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();

            hall_wizard gol = GameObject.Find("hall_wizard").GetComponent<hall_wizard>();

            Destroy(gameObject);
            gol.hp = gol.hp - 10;



        }
        Destroy(gameObject, 0.3f);
    }
}
