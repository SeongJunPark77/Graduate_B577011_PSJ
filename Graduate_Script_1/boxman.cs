using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class boxman : MonoBehaviour
{
    public ParticleSystem summon;
    public ParticleSystem summon2;
    // Start is called before the first frame update
    private bool spawnCheck = false;

    public float runSpeed;
    public int hp;

    public GameObject me;

    NavMeshAgent nav;

    public GameObject boxman2;

    public GameObject player;
    Animator player_animator;

    public GameObject player2;
    Animator player_animator2;

    public GameObject player3;
    Animator player_animator3;

    public GameObject player4;
    Animator player_animator4;


    public Transform bigboss;



    public GameObject Sword;
    public GameObject Staff;
    public GameObject Axe;
    public GameObject Arrow;

    Animator animator;

    private AudioSource damaudio;
    public AudioClip dam_sound;

    bool isWalking;
    bool isAttacking;
    bool isDead;
    void Awake()
    {
        summon.gameObject.SetActive(false);
        summon2.gameObject.SetActive(false);

        Invoke("navigate", 2);

        boxman2.SetActive(false);

        player_animator = player.GetComponent<Animator>();
        player_animator2 = player2.GetComponent<Animator>();
        player_animator3 = player3.GetComponent<Animator>();
        player_animator4 = player4.GetComponent<Animator>();


        animator = GetComponent<Animator>();

        nav = GetComponent<NavMeshAgent>();
        nav.speed = runSpeed;

        this.damaudio = this.gameObject.AddComponent<AudioSource>();
        this.damaudio.clip = this.dam_sound;
        this.damaudio.loop = false;
        this.damaudio.playOnAwake = false;
        this.damaudio.volume = 0.20f;
    }

    // Update is called once per frame


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
            Destroy(gameObject, 3f);
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

        

    }

    void navigate()
    {
        float distance = Vector3.Distance(bigboss.position, transform.position);

        if (nav.destination != bigboss.transform.position)
        {
            if (distance > 14.0f)
            {
                nav.SetDestination(transform.position);
                isWalking = false;

            }
            else if (distance <= 14.0f)
            {
                nav.SetDestination(bigboss.transform.position);
            }
            if (hp <= 0)
            {
                isDead = true;
                nav.SetDestination(transform.position);

                boxman2.SetActive(true);
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



        if (col.gameObject == Sword)
        {
            if (player_animator3.GetBool("isAttacking") == true)
            {
                summon2.gameObject.SetActive(true);
                summon2.Play();
                damaudio.Play();
                hp--;
            }


        }
        if (col.gameObject == Axe)
        {
            if (player_animator4.GetBool("isAttacking") == true)
            {
                summon2.gameObject.SetActive(true);
                summon2.Play();
                damaudio.Play();
                hp--;

            }

            if (player_animator4.GetBool("isSkill") == true)
            {
                summon.gameObject.SetActive(true);
                summon.Play();
                damaudio.Play();
                for (int i = 0; i < 2; i++)
                {
                    hp--;
                }

            }

        }



    }

    public void Spawn()
    {
        // 사용기능
        spawnCheck = false;
    }

    void Update()
    {
        if (hp <= 0)
        {
            if (spawnCheck)
                return;
            spawnCheck = true;
            Destroy(gameObject, 0.3f);
            SceneManager.LoadScene("Tuto_sto3", LoadSceneMode.Additive);
        }


        AnimationUpdate();
        navigate();

    }
}
