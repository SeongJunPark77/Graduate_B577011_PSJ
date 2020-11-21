using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossatk : MonoBehaviour
{
    public ParticleSystem summon;
    public GameObject union;

    public GameObject archer;
    public GameObject wizard;
    public GameObject knight;
    public GameObject warlord;

    public GameObject boss;
    Animator boss_animator;

    void Awake()
    {
        summon.gameObject.SetActive(false);
        boss_animator = boss.GetComponent<Animator>();
    }

    void Update()
    {
        summon.transform.position = union.transform.position + new Vector3(0,0.7f,0);

        boss Boss = GameObject.Find("SnowTiger").GetComponent<boss>();

        if(Boss.hp<= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerStay(Collider col)
    {
      
        //archerhp Boss = GameObject.Find("archerhp").GetComponent<archerhp>();
        if (col.gameObject == archer)
        {


            if (boss_animator.GetBool("isAttacking") == true)
            {
                Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);

                summon.gameObject.SetActive(true);
                summon.Play();

                archerhp.archer_hp--;
                
            }
        }

        //wizardhp Wizard = GameObject.Find("wizardhp").GetComponent<wizardhp>();
        if (col.gameObject == wizard)
        {
          
            if (boss_animator.GetBool("isAttacking") == true)
            {

                Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);

                summon.gameObject.SetActive(true);
                summon.Play();

                wizardhp.wizard_hp--;
            }
        }

        //knighthp Knight = GameObject.Find("knighthp").GetComponent<knighthp>();
        if (col.gameObject == knight)
        {
            
            if (boss_animator.GetBool("isAttacking") == true)
            {
                Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);

                summon.gameObject.SetActive(true);
                summon.Play();


                knighthp.knight_hp--;
            }
        }

        //warlordhp Warlord = GameObject.Find("warlordhp").GetComponent<warlordhp>();
        if (col.gameObject == warlord)
        {
       
            if (boss_animator.GetBool("isAttacking") == true)
            {
                Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);

                summon.gameObject.SetActive(true);
                summon.Play();

                warlordhp.warlord_hp--;
            }
        }

    }


    }


