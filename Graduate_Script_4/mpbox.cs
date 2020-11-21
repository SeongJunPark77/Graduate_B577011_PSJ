using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mpbox : MonoBehaviour
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
        //archermp Armp = GameObject.Find("archermp").GetComponent<archermp>();
       
        if (col.gameObject == archer)
        {
            GameObject.Find("potion_get_sound").GetComponent<AudioSource>().Play();
            archermp.archer_mp ++;

            summon.gameObject.SetActive(true);
            summon.Play();

            Destroy(gameObject);
        }

        //wizardmp Wzmp = GameObject.Find("wizardmp").GetComponent<wizardmp>();

        if (col.gameObject == wizard)
        {
            GameObject.Find("potion_get_sound").GetComponent<AudioSource>().Play();
            wizardmp.wizard_mp++;

            summon.gameObject.SetActive(true);
            summon.Play();

            Destroy(gameObject);
        }

        //knightmp Knimp = GameObject.Find("knightmp").GetComponent<knightmp>();

        if (col.gameObject == knight)
        {
            GameObject.Find("potion_get_sound").GetComponent<AudioSource>().Play();
            knightmp.knight_mp++;

            summon.gameObject.SetActive(true);
            summon.Play();

            Destroy(gameObject);
        }
        //warlordmp Warmp = GameObject.Find("warlordmp").GetComponent<warlordmp>();

        if (col.gameObject == warlord)
        {
            GameObject.Find("potion_get_sound").GetComponent<AudioSource>().Play();
            warlordmp.warlord_mp++;

            summon.gameObject.SetActive(true);
            summon.Play();

            Destroy(gameObject);
        }

        Destroy(gameObject, 10f);
    }
}
