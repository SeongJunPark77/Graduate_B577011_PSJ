using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class boss2scri : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject goblin;
    public GameObject barr;
    public GameObject skill;
    public GameObject scroll2;
    public GameObject portal_stage3;
    public GameObject portal_sidestage_01;
    public int hp = 1500;
    public int barrier = 500;
    public Transform target;
    public Transform bigboss;

    NavMeshAgent nav;
    Animator animator;

    bool isRunning;
    bool isSkill;
    bool isDead;

    private bool spawnCheck = false;

    void Start()
    {
        portal_sidestage_01.SetActive(false);
        portal_stage3.SetActive(false);
        scroll2.SetActive(false);
        skill.SetActive(false);
        animator = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
        InvokeRepeating("Spawnitem", 3, 2.5f);

    }

    void Spawnitem()
    {
        float randomX = Random.Range(-18f, 25f);
        float randomZ = Random.Range(-20f, 14f);
        if (barrier > 0)
        {
          GameObject enemy = Instantiate(goblin, new Vector3(randomX, 0f, randomZ), Quaternion.identity)as GameObject;
        }
    }

    void navigate()
    {
        float distance = Vector3.Distance(bigboss.position, transform.position);
        if (barrier <= 0)
        {
            if (nav.destination != bigboss.transform.position)
            {

                if (distance > 35.0f)
                {
                    nav.SetDestination(transform.position);
                    isRunning = false;

                }
                else if (distance <= 35.0f)
                {
                    isRunning = true;
                    nav.SetDestination(bigboss.transform.position);

                    if (distance <= 10.0f)
                    {
                        transform.LookAt(target);
                        skill.SetActive(true);
                        isSkill = true;
                        nav.SetDestination(transform.position);

                    }
                    else if (distance >= 10.0f)
                    {
                        skill.SetActive(false);
                        isSkill = false;

                        nav.SetDestination(bigboss.transform.position);
                    }

                }
                if (hp <= 0)
                {
                    skill.SetActive(false);
                    isDead = true;
                    nav.SetDestination(transform.position);

                    Destroy(gameObject,0.5f);

                    scroll2.SetActive(true);
                    scroll2.transform.position = this.transform.position + new Vector3(0, 0.55f, 0);

                    portal_stage3.SetActive(true);
                    portal_sidestage_01.SetActive(true);
                }


            }
            else
            {
                nav.SetDestination(transform.position);
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

        if (isDead == true)
        {
            animator.SetBool("isDead", true);
            
        }
        else
        {
            animator.SetBool("isDead", false);
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

    public void Spawn()
    {
        spawnCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        navigate();
        AnimationUpdate();
        if (barrier<=0)
        {
            barr.SetActive(false);
        }

        if(hp<=0)
        {
            if (spawnCheck)
                return;
            spawnCheck = true;

            SceneManager.LoadScene("main_sto4", LoadSceneMode.Additive);
        }
    }
}
