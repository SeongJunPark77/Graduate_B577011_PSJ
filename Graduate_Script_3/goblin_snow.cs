using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class goblin_snow : MonoBehaviour
{
    public ParticleSystem summon3;
    public GameObject archer;
    public GameObject wizard;
    public GameObject knight;
    public GameObject warlord;
    private bool spawnCheck = false;
    public ParticleSystem summon;
    public ParticleSystem summon2;
    public GameObject Sword;
    public GameObject Axe;

    public GameObject player;
    Animator player_animator;

    public Transform bigboss;
    public Transform target;

    NavMeshAgent nav;
    Animator animator;

    public GameObject player3;
    Animator player_animator3;

    public GameObject player4;
    Animator player_animator4;

    bool isRunning = false;
    bool isAttacking = false;

    public int hp = 100;


    void Awake()
    {
        
        summon3.gameObject.SetActive(false);
        summon.gameObject.SetActive(false);
        summon2.gameObject.SetActive(false);

        player_animator = player.GetComponent<Animator>();

        animator = GetComponent<Animator>();
        player_animator3 = player3.GetComponent<Animator>();
        player_animator4 = player4.GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
    }


    void AnimationUpdate()
    {
        if (isRunning == true)
        {
            animator.SetBool("isRun", true);
        }
        else
        {
            animator.SetBool("isRun", false);
        }

        if (isAttacking == true)
        {
            animator.SetBool("isSkill", true);
            isAttacking = false;
        }
        else
        {

            animator.SetBool("isSkill", false);
        }



    }

    void navigate()
    {
        float distance = Vector3.Distance(bigboss.position, transform.position);

        if (nav.destination != bigboss.transform.position)
        {

            if (distance > 25.0f)
            {
                nav.SetDestination(transform.position);
                isRunning = false;
            }
            else if (distance <= 25.0f)
            {
                isRunning = true;
                nav.SetDestination(bigboss.transform.position);

                if (distance <= 8.0f)
                {
                    nav.speed = 7.0f;
                    transform.LookAt(target);
                    isAttacking = true;
                    if (distance <= 1.0f)
                    {
                        nav.SetDestination(transform.position);

                    }
                    else
                    {
                        nav.SetDestination(bigboss.transform.position);
                    }
                }
                else if(distance>8.0f)
                {
                    isAttacking = false;
                    nav.speed = 3.0f;
                }

            }

        }
        else
        {
            nav.SetDestination(transform.position);
        }
    }

    void OnTriggerStay(Collider col)
    {
        Vector3 pos = col.GetComponent<Transform>().position;
        summon.transform.position = this.transform.position + new Vector3(0, 1, 0);
        summon2.transform.position = this.transform.position + new Vector3(0, 1, 0);
        if (col.gameObject == Sword)
        {
            if (player_animator3.GetBool("isAttacking") == true)
            {
                summon2.gameObject.SetActive(true);
                summon2.Play();
                GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
                hp = hp - Damage.kniatk;
            }
        }
        if (col.gameObject == Axe)
        {
            if (player_animator4.GetBool("isAttacking") == true)
            {
                summon2.gameObject.SetActive(true);
                summon2.Play();
                GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
                hp = hp - Damage.waratk;

            }

            if (player_animator4.GetBool("isSkill") == true)
            {
                summon.gameObject.SetActive(true);
                summon.Play();
                GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
                hp = hp - Damage.warskill;

            }
        }

        if(col.gameObject==archer)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);

            summon3.gameObject.SetActive(true);
            summon3.Play();
            archerhp.archer_hp = archerhp.archer_hp - 0.5f;
        }

        if (col.gameObject == wizard)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);

            summon3.gameObject.SetActive(true);
            summon3.Play();
            wizardhp.wizard_hp = wizardhp.wizard_hp - 0.5f;
        }

        if (col.gameObject == knight)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);

            summon3.gameObject.SetActive(true);
            summon3.Play();
            knighthp.knight_hp = knighthp.knight_hp - 0.5f;
        }

        if (col.gameObject == warlord)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);

            summon3.gameObject.SetActive(true);
            summon3.Play();
            warlordhp.warlord_hp = warlordhp.warlord_hp - 0.5f;
        }



    }

    // Update is called once per frame
    void Update()
    {
        summon3.transform.position = bigboss.transform.position + new Vector3(0, 0.7f, 0);
        AnimationUpdate();
        navigate();

        if (hp <= 0)
        {
            Destroy(gameObject, 0.5f);
        }
    }
}
