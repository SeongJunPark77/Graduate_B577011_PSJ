using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golem_main : MonoBehaviour
{
    public GameObject hall;
    public GameObject hall2;
    public GameObject hall3;
    public GameObject hall4;

    public ParticleSystem summon;
    public ParticleSystem summon2;
    // Start is called before the first frame update
    public GameObject goblin;
    public GameObject goblin2;
    public GameObject meteo2;
    public Transform player;
    public GameObject scroll4;
    public GameObject sword;
    public GameObject axe;

    public GameObject portal_stage03;
    public GameObject portal_sidestage_02;

    public int hp = 1000;

    public GameObject player_1;
    Animator player_animator;

    public GameObject player_2;
    Animator player_animator2;

    Animator animator;

    bool isDeath;

    void Start()
    {
        summon.gameObject.SetActive(false);
        summon2.gameObject.SetActive(false);
        portal_sidestage_02.SetActive(false);
        portal_stage03.SetActive(false);
        scroll4.SetActive(false);

        player_animator = player_1.GetComponent<Animator>();
        player_animator2 = player_2.GetComponent<Animator>();

        animator = GetComponent<Animator>();

        InvokeRepeating("Spawnitem", 2, 1.3f);
        InvokeRepeating("Spawnitem2", 3, 0.83f);
    }

    // Update is called once per frame
    void Update()
    {
        AnimationUpdate();
    }

    void Spawnitem()
    {
        Instantiate(goblin, (player.transform.position + new Vector3(0f, 11f, 0f)), goblin.transform.rotation);
        Instantiate(meteo2, player.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
    }

    void Spawnitem2()
    {
        float randomX = Random.Range(-15f, 25f);
        float randomZ = Random.Range(-21f, 5f);
      
         Instantiate(goblin2, new Vector3(randomX, 11f, randomZ), goblin2.transform.rotation);
        Instantiate(meteo2, new Vector3(randomX, 0, randomZ), Quaternion.identity);


    }

        void AnimationUpdate()
    {
        if (hp <= 0)
        {

            portal_stage03.SetActive(true);
            portal_sidestage_02.SetActive(true);
            scroll4.SetActive(true);

            isDeath = true;
        }
        if (isDeath == true)
        {
            animator.SetBool("isDeath", true);
            isDeath = false;
            Destroy(gameObject, 1.5f);
        }
        else
        {
            animator.SetBool("isDeath", false);
        }
    }

    void OnTriggerStay(Collider c)
    {
        Vector3 pos = c.GetComponent<Transform>().position;
        summon.transform.position = this.transform.position + new Vector3(0, 1, 0);
        summon2.transform.position = this.transform.position + new Vector3(0, 1, 0);
        //summon2.transform.position = pos + new Vector3(0, 1, 0);

        

            if (c.gameObject == sword)
            {
                if (player_animator.GetBool("isAttacking") == true)
                {
                    summon2.gameObject.SetActive(true);
                    summon2.Play();
                    GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();

                if (hall.activeSelf == false && hall2.activeSelf == false && hall3.activeSelf == false && hall4.activeSelf == false)
                {
                    hp = hp - Damage.kniatk;
                }
                }

            }
            if (c.gameObject == axe)
            {
                if (player_animator2.GetBool("isAttacking") == true)
                {
                    summon2.gameObject.SetActive(true);
                    summon2.Play();
                    GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();

                if (hall.activeSelf == false && hall2.activeSelf == false && hall3.activeSelf == false && hall4.activeSelf == false)
                {
                    hp = hp - Damage.waratk;

                }

                }

                if (player_animator2.GetBool("isSkill") == true)
                {
                    summon.gameObject.SetActive(true);
                    summon.Play();
                    GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
                if (hall.activeSelf == false && hall2.activeSelf == false && hall3.activeSelf == false && hall4.activeSelf == false)
                {
                    hp = hp - Damage.warskill;
                }

                }

            }
        
    }
}
