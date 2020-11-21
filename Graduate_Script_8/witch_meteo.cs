using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witch_meteo : MonoBehaviour
{
    public ParticleSystem summon;
    public GameObject union;
    // Start is called before the first frame update
    float timeSpan;
    float checkTime;

    public GameObject terra;

    public GameObject archer;
    public GameObject wizard;
    public GameObject knight;
    public GameObject warlord;
    void Start()
    {
        summon.gameObject.SetActive(false);
        timeSpan = 0.0f;
        checkTime = 0.01f;

    }

    void Update()
    {
        summon.transform.position = union.transform.position + new Vector3(0, 0.7f, 0);
        timeSpan += Time.deltaTime;

        if (timeSpan < checkTime)
        {
        }
        else if (timeSpan >= checkTime)
        {
            this.transform.position += new Vector3(0, -0.4f, 0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == terra)
        {
            Destroy(gameObject);

        }
    }

    void OnTriggerStay(Collider c)
    {
        if (c.gameObject == archer)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            archerhp.archer_hp = archerhp.archer_hp - 0.75f;

        }

        if (c.gameObject == wizard)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            wizardhp.wizard_hp = wizardhp.wizard_hp - 0.75f;

        }

        if (c.gameObject == knight)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            knighthp.knight_hp = knighthp.knight_hp - 0.75f;

        }

        if (c.gameObject == warlord)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            warlordhp.warlord_hp = warlordhp.warlord_hp - 0.75f;

        }
    }
}
