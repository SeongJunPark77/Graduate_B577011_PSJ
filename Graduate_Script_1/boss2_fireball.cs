using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss2_fireball : MonoBehaviour
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

        if (c.gameObject == aboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            boss2scri witch = GameObject.Find("boss2").GetComponent<boss2scri>();
            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            Destroy(gameObject);

            witch.hp = witch.hp - Damage.wizskill;



        }

        if (c.gameObject == barr)
        {
            Destroy(gameObject);
        }

        Destroy(gameObject, 0.3f);
    }
}
