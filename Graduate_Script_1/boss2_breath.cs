﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss2_breath : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem summon;
    public GameObject union;
    public GameObject archer;
    public GameObject wizard;
    public GameObject knight;
    public GameObject warlord;

    void Start()
    {
        summon.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        summon.transform.position = union.transform.position + new Vector3(0, 0.7f, 0);

    }

    void OnTriggerStay(Collider c)
    {
        if (c.gameObject == archer)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            archerhp.archer_hp--;
        }

        if (c.gameObject == wizard)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            wizardhp.wizard_hp--;
        }

        if (c.gameObject == knight)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            knighthp.knight_hp--;
        }

        if (c.gameObject == warlord)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            warlordhp.warlord_hp--;
        }

    }
}
