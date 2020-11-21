using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class goblinscri : MonoBehaviour
{
    // Start is called before the first frame update
    private bool spawnCheck = false;
    public ParticleSystem summon;
    public ParticleSystem summon2;

    public GameObject Bullet;
    public Transform FirePos;

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

    public int hp=100;

    public GameObject arrow;

    void Awake()
    {
        summon.gameObject.SetActive(false);
        summon2.gameObject.SetActive(false);
        InvokeRepeating("Spawnitem", 0.45f, 1.25f);

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
            animator.SetBool("isAttack", true);
            isAttacking = false;
        }
        else
        {

            animator.SetBool("isAttack", false);
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

                if (distance <= 6.0f)
                {
                    transform.LookAt(target);
                    isAttacking = true;
                    nav.SetDestination(transform.position);

                }
                else
                {
                    isAttacking = false;

                    nav.SetDestination(bigboss.transform.position);
                }

            }
            //if (hp <= 0)
            //{

            //    isDead = true;
            //    potal1.SetActive(true);
            //    potal2.SetActive(true);
            //    potal3.SetActive(true);
            //    nav.SetDestination(transform.position);

            //}


        }
        else
        {
            nav.SetDestination(transform.position);
        }
    }

    void Spawnitem()
    {

        if (isAttacking == true)
        {
            Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);


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
    }

    void OnTriggerEnter(Collider col)
    {

        //archerhp Boss = GameObject.Find("archerhp").GetComponent<archerhp>();
        if (col.gameObject == arrow)
        {

            hp = hp - Damage.aratk;


        }


    }
    public void Spawn()
    {
        spawnCheck = false;
    }
    // Update is called once per frame
    void Update()
    {
        AnimationUpdate();
        navigate();

        if (hp<=0)
        {
            Destroy(gameObject, 0.5f);
        }

        if (hp <= 1)
        {
            boss2scri witch = GameObject.Find("boss2").GetComponent<boss2scri>();
            if (spawnCheck)
                return;
            spawnCheck = true;

            witch.barrier = witch.barrier - 50;

        }
    }
}
