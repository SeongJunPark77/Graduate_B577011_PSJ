using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class witch_creature2 : MonoBehaviour
{
    public GameObject union;
    public ParticleSystem summon3;
    public ParticleSystem summon2;
    public ParticleSystem summon1;
    NavMeshAgent nav;
    Animator animator;

    public Transform bigboss;
    public Transform me;

    bool isRunning;
    bool isSkill;

    public GameObject archer;
    public GameObject wizard;
    public GameObject knight;
    public GameObject warlord;

    public int hp = 300;

    public GameObject player;
    Animator player_animator;

    public GameObject player2;
    Animator player_animator2;

    public GameObject Sword;
    public GameObject Axe;


    // Start is called before the first frame update
    void Start()
    {
        summon3.gameObject.SetActive(false);
        summon2.gameObject.SetActive(false);
        summon1.gameObject.SetActive(false);


        player_animator = player.GetComponent<Animator>();
        player_animator2 = player2.GetComponent<Animator>();

        animator = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
    }
    void navigate()
    {
        float distance = Vector3.Distance(bigboss.position, transform.position);

        if (hp <= 300)
        {
            if (nav.destination != bigboss.transform.position)
            {

                if (distance > 15.0f)
                {
                    nav.SetDestination(transform.position);
                    isRunning = false;

                }
                else if (distance <= 15.0f)
                {
                    isRunning = true;
                    nav.SetDestination(bigboss.transform.position);

                }

                if (distance <= 2.0f)
                {
                    isSkill = true;
                    nav.SetDestination(transform.position);

                }
                else if (distance > 2.0f)
                {
                    isSkill = false;

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
        summon3.transform.position = this.transform.position + new Vector3(0, 1.3f, 0);
        summon2.transform.position = this.transform.position + new Vector3(0, 1.3f, 0);

        if (c.gameObject == archer)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon1.gameObject.SetActive(true);
            summon1.Play();
            archerhp.archer_hp = archerhp.archer_hp - 0.8f;
        }
        if (c.gameObject == wizard)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon1.gameObject.SetActive(true);
            summon1.Play();
            wizardhp.wizard_hp = wizardhp.wizard_hp - 0.8f;
        }
        if (c.gameObject == knight)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon1.gameObject.SetActive(true);
            summon1.Play();
            knighthp.knight_hp = knighthp.knight_hp - 0.8f;
        }
        if (c.gameObject == warlord)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon1.gameObject.SetActive(true);
            summon1.Play();
            warlordhp.warlord_hp = warlordhp.warlord_hp - 0.8f;
        }


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
        summon1.transform.position = union.transform.position + new Vector3(0, 0.7f, 0);
        AnimationUpdate();
        navigate();
    }
}
