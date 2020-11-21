using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class boss : MonoBehaviour
{
    public GameObject goblin;
    // Start is called before the first frame update
    public float runSpeed;
    public int hp;
    public ParticleSystem summon;
    public ParticleSystem summon2;
    public GameObject scroll1;
    public GameObject me;

    NavMeshAgent nav;

    public GameObject potal1;

    public GameObject player;
    Animator player_animator;

    public GameObject player2;
    Animator player_animator2;

    public GameObject player3;
    Animator player_animator3;

    public GameObject player4;
    Animator player_animator4;

    public Transform target;
    public Transform bigboss;

    public GameObject Sword;
    public GameObject Staff;
    public GameObject Axe;
    public GameObject Arrow;

    Animator animator;

    bool isSwit;
    bool isWalking;
    bool isAttacking;
    bool isDead;

    void Awake()
    {

        InvokeRepeating("Spawnitem", 2, 2.5f);

        summon.gameObject.SetActive(false);
        summon2.gameObject.SetActive(false);
        scroll1.SetActive(false);
        Invoke("navigate", 2);

        potal1.SetActive(false);


        player_animator = player.GetComponent<Animator>();
        player_animator2 = player2.GetComponent<Animator>();
        player_animator3 = player3.GetComponent<Animator>();
        player_animator4 = player4.GetComponent<Animator>();


        animator = GetComponent<Animator>();

        nav = GetComponent<NavMeshAgent>();
        nav.speed = runSpeed;
    }


    // Update is called once per frame
    void Spawnitem()
    {
        float randomX = Random.Range(-15f, 25f);
        float randomZ = Random.Range(-21f, 5f);


        if (hp > 0 && hp <= 600)
        {
            Instantiate(goblin, new Vector3(randomX, 0, randomZ), Quaternion.identity);
        }

    }

    void AnimationUpdate()
    {
        if (isWalking == true)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
        

        if (isDead == true)
        {
            animator.SetBool("isDead", true);
            isDead = false;
            Destroy(gameObject,2f);
        }
        else
        {
            animator.SetBool("isDead", false);
        }

        if (isAttacking == true)
        {
            animator.SetBool("isAttacking", true);
            isAttacking = false;
        }
        else
        {
         
            animator.SetBool("isAttacking", false);
        }

        if (isSwit == true)
        {
            animator.SetBool("isSwit", true);
            isSwit = false;
        }
        else
        {

            animator.SetBool("isSwit", false);
        }

    }

    void navigate()
    {
        float distance = Vector3.Distance(bigboss.position, transform.position);

        if (nav.destination != bigboss.transform.position)
        {
           
            if (distance > 35.0f)
            {
                nav.SetDestination(transform.position);
                isWalking = false;
            
            }
            else if (distance <= 35.0f)
            {
                isWalking = true;
                nav.SetDestination(bigboss.transform.position);

                if (distance <= 3.0f)
                {
                    //transform.LookAt(target);
                    isAttacking = true;
                    nav.SetDestination(transform.position);

                }
                else
                {
                    isAttacking = false;
                    isSwit = true;
                    nav.SetDestination(bigboss.transform.position);
                }

            }
            if (hp <= 0)
            {

                isDead = true;
                potal1.SetActive(true);
                scroll1.SetActive(true);

                scroll1.transform.position = this.transform.position+new Vector3(0,1.2f,0);
                nav.SetDestination(transform.position);
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
        summon.transform.position = pos + new Vector3(0, 1, 0);
        summon2.transform.position = pos + new Vector3(0, 1, 0);
        if (col.gameObject==Sword)
        {
            if(player_animator3.GetBool("isAttacking")==true)
            {
                summon2.gameObject.SetActive(true);
                summon2.Play();
                GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
                hp =hp-Damage.kniatk;
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

    void OnTriggerExit(Collider other)
    {
        
    }

    void Update()
    {
       


        AnimationUpdate();
        navigate();

    }
}
