using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpbox : MonoBehaviour
{
    public GameObject archer;
    public GameObject wizard;
    public GameObject knight;
    public GameObject warlord;
    public GameObject union;

    public ParticleSystem summon;
    // Start is called before the first frame update
    void Start()
    {
        summon.gameObject.SetActive(false);
    }



    // Update is called once per frame
    void Update()
    {
        summon.transform.position = union.transform.position + new Vector3(0, 0.7f, 0);
    }



    void OnTriggerEnter(Collider col)
    {
        int heal = 15;

        //archerhp Armp = GameObject.Find("archerhp").GetComponent<archerhp>();

        if (col.gameObject == archer)
        {
            GameObject.Find("potion_get_sound").GetComponent<AudioSource>().Play();
            archerhp.archer_hp = archerhp.archer_hp + heal;

            summon.gameObject.SetActive(true);
            summon.Play();

            Destroy(gameObject);
        }

        //wizardhp Wzmp = GameObject.Find("wizardhp").GetComponent<wizardhp>();

        if (col.gameObject == wizard)
        {
            GameObject.Find("potion_get_sound").GetComponent<AudioSource>().Play();
            wizardhp.wizard_hp= wizardhp.wizard_hp+heal;

            summon.gameObject.SetActive(true);
            summon.Play();

            Destroy(gameObject);
        }

        //knighthp Knimp = GameObject.Find("knighthp").GetComponent<knighthp>();

        if (col.gameObject == knight)
        {
            GameObject.Find("potion_get_sound").GetComponent<AudioSource>().Play();
            knighthp.knight_hp= knighthp.knight_hp+heal;

            summon.gameObject.SetActive(true);
            summon.Play();

            Destroy(gameObject);
        }
        //warlordhp Warmp = GameObject.Find("warlordhp").GetComponent<warlordhp>();

        if (col.gameObject == warlord)
        {
            GameObject.Find("potion_get_sound").GetComponent<AudioSource>().Play();
            warlordhp.warlord_hp= warlordhp.warlord_hp+heal;

            summon.gameObject.SetActive(true);
            summon.Play();

            Destroy(gameObject);
        }

        Destroy(gameObject, 10f);
    }
}
