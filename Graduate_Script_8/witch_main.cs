using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class witch_main : MonoBehaviour
{
    public ParticleSystem summon3;
    public ParticleSystem summon2;
    // Start is called before the first frame update
    NavMeshAgent nav;
    Animator animator;
    public ParticleSystem summon;
    public ParticleSystem burst;
    public GameObject meteo;
    public GameObject meteo2;
    public Transform bigboss;
    public Transform me;

    public float hp = 3500;
    private bool spawnCheck = false;
    private bool spawnCheck2 = false;
    private bool spawnCheck3 = false;
    private bool spawnCheck4 = false;
    private bool spawnCheck5 = false;
    public GameObject firewing;

    public GameObject warning;
    public GameObject warning_a;
    public GameObject paten1;
    public GameObject paten2;
    public GameObject paten3;
    public GameObject paten4;

    public GameObject creature1;
    public GameObject creature2;

    bool isRunning;
    bool isSkill;

    public GameObject room;
    public GameObject sword1;
    public GameObject sword2;

    public GameObject player;
    Animator player_animator;

    public GameObject player2;
    Animator player_animator2;

    public GameObject Sword;
    public GameObject Axe;

    public GameObject hitbox;

    void Start()
    {
        summon3.gameObject.SetActive(false);
        summon2.gameObject.SetActive(false);
        GameObject.Find("singlecanvas").GetComponent<AudioSource>().Stop();

        player_animator = player.GetComponent<Animator>();
        player_animator2 = player2.GetComponent<Animator>();
        animator = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
        GameObject.Find("back_sound").GetComponent<AudioSource>().Play();

        creature1.SetActive(false);
        creature2.SetActive(false);

        firewing.SetActive(false);
        warning.SetActive(false);
        warning_a.SetActive(false);
        sword1.SetActive(false);
        sword2.SetActive(false);
        summon.gameObject.SetActive(false);
        burst.gameObject.SetActive(false);
        InvokeRepeating("Spawnitem", 2, 0.5f);

        InvokeRepeating("Spawnitem2", 2, 0.27f);

        InvokeRepeating("Spawnitem3", 2, 5f);

        InvokeRepeating("Spawnitem4", 1, 2.5f);

    }
    void patern1()
    {
        if(hp <= 2900)
        {
            if (spawnCheck2)
                return;
            spawnCheck2 = true;
            GameObject.Find("dragon_sound").GetComponent<AudioSource>().Play();
            creature1.SetActive(true);
            creature2.SetActive(true);


            paten1.SetActive(true);
            Destroy(paten1, 3);
        }
    }


    void patern2()
    {
        if (hp <= 1800)
        {
            if (spawnCheck3)
                return;
            spawnCheck3 = true;

            paten2.SetActive(true);
            Destroy(paten2, 3);
            sword1.SetActive(true);
        }


    }

    void patern3()
    {
        if (hp <= 1300)
        {
            if (spawnCheck4)
                return;
            spawnCheck4 = true;

            paten3.SetActive(true);
            Destroy(paten3, 3);
            sword2.SetActive(true);
        }
    }

    void patern4()
    {
        if (hp <= 700)
        {
            if (spawnCheck5)
                return;
            spawnCheck5 = true;

            paten4.SetActive(true);
            Destroy(paten4, 3);
        }
    }

    void Spawnitem()
    {
        float randomX = Random.Range(-21f, 30f);

        float randomZ = Random.Range(-25f, 17f);
        if (hp <= 2100)
        {
            Instantiate(meteo, new Vector3(randomX, 10.0f, randomZ), Quaternion.identity);
            Instantiate(meteo2, new Vector3(randomX, 0, randomZ), Quaternion.identity);
        }
    }

    void Spawnitem2()
    {
        float distance = Vector3.Distance(bigboss.position, transform.position);
        if (hp <= 2100)
        {
            if (distance > 5.0f)
            {

                Instantiate(meteo, (bigboss.transform.position + new Vector3(0, 10.0f, 0)), Quaternion.identity);
                Instantiate(meteo2, bigboss.transform.position + new Vector3(0,0,0), Quaternion.identity);
            }
        }

    }

    void Spawnitem3()
    {
        if (hp > 2100)
        {
            me.transform.position = bigboss.transform.position + new Vector3(2.0f, 0, 1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
        }
    }

    void Spawnitem4()
    {
        if (hp <=700)
        {
            Instantiate(hitbox, me.transform.position, me.transform.rotation);
            burst.transform.position = this.transform.position;
            burst.gameObject.SetActive(true);
            burst.Play();
        }
    }
    void navigate()
    {
        float distance = Vector3.Distance(bigboss.position, transform.position);
        if(hp<=3500 && hp>2100)
        {
            if(distance<11.0f)
            {
                isSkill = true;
            }
            else
            {
                isSkill = false;
            }
        }


        if (hp <= 2100)
        {
            if (nav.destination != bigboss.transform.position)
            {

                if (distance > 40.0f)
                {
                    nav.SetDestination(transform.position);
                    isRunning = false;

                }
                else if (distance <= 40.0f)
                {
                    isRunning = true;
                    nav.SetDestination(bigboss.transform.position);

                }
                if (hp <= 0)
                {

                    nav.SetDestination(transform.position);

                    Destroy(gameObject);
                }
            }
        }
    }

    void AnimationUpdate()
    {
        if (isRunning == true)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if (isSkill == true)
        {
            animator.SetBool("isSkill", true);
            isSkill = false;
        }
        else
        {

            animator.SetBool("isSkill", false);
        }



    }

    void OnTriggerStay(Collider c)
    {
        Vector3 pos = c.GetComponent<Transform>().position;
        summon3.transform.position = this.transform.position + new Vector3(0, 1, 0);
        summon2.transform.position = this.transform.position + new Vector3(0, 1, 0);
        if (c.gameObject == Sword)
        {
            if (player_animator.GetBool("isAttacking") == true)
            {
                summon2.gameObject.SetActive(true);
                summon2.Play();
                GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
                hp = hp - Damage.kniatk;
            }

        }
        if (c.gameObject == Axe)
        {
            if (player_animator2.GetBool("isAttacking") == true)
            {
                summon2.gameObject.SetActive(true);
                summon2.Play();
                GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
                hp = hp - Damage.waratk;

            }

            if (player_animator2.GetBool("isSkill") == true)
            {
                summon3.gameObject.SetActive(true);
                summon3.Play();
                GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
                hp = hp - Damage.warskill;

            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        AnimationUpdate();
        navigate();
        patern1();
        patern2();
        patern3();
        patern4();
        if (hp <= 2100)
        {
            if (spawnCheck)
                return;
            spawnCheck = true;
            room.SetActive(false);
            firewing.SetActive(true);
            warning.SetActive(true);
            warning_a.SetActive(true);
            Destroy(warning, 3.5f);
            Destroy(warning_a, 1f);
            this.transform.position = new Vector3(6, 0, 9);

            GameObject.Find("back_sound").GetComponent<AudioSource>().Stop();

            GameObject.Find("back_sound2").GetComponent<AudioSource>().Play();
        }

        summon.transform.position = this.transform.position;
        transform.LookAt(bigboss);

    }
    public void Spawn()
    {
        spawnCheck = false;
        spawnCheck2 = false;
        spawnCheck3 = false;
        spawnCheck4 = false;
        spawnCheck5 = false;

    }
}
