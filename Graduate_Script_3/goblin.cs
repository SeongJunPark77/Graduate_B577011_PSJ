using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goblin : MonoBehaviour
{
    public ParticleSystem summon;
    public ParticleSystem summon2;
    private bool spawnCheck = false;
    private bool spawnCheck2 = false;

    public int hp = 1000;

    public GameObject player3;
    Animator player_animator3;

    public GameObject player4;
    Animator player_animator4;

    public GameObject Sword;
    public GameObject Axe;

    public GameObject god;
    public GameObject portal;
    private AudioSource damaudio;
    public AudioClip dam_sound;
    Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        summon.gameObject.SetActive(false);
        summon2.gameObject.SetActive(false);
        player_animator3 = player3.GetComponent<Animator>();
        player_animator4 = player4.GetComponent<Animator>();

        this.damaudio = this.gameObject.AddComponent<AudioSource>();
        this.damaudio.clip = this.dam_sound;
        this.damaudio.loop = false;
        this.damaudio.playOnAwake = false;
        this.damaudio.volume = 0.20f;
        animator = GetComponent<Animator>();
        //god.SetActive(false);
        //portal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if( hp <= 0)
        {
            if (spawnCheck2)
                return;
            spawnCheck2 = true;

            portal.SetActive(true);
            SceneManager.LoadScene("Tuto_sto6", LoadSceneMode.Additive);
            Destroy(gameObject, 0.3f);
        }


        if (hp <= 900)
        {
            if (spawnCheck)
                return;
            spawnCheck = true;

            god.SetActive(true);
            SceneManager.LoadScene("Tuto_sto5-2", LoadSceneMode.Additive);

        }

    }

    public void Spawn()
    {
        spawnCheck = false;
        spawnCheck2 = false;
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
                if (hp > 10)
                {
                    hp--;
                }
            }

        }
        if (col.gameObject == Axe)
        {
            if (player_animator4.GetBool("isAttacking") == true)
            {
                summon2.gameObject.SetActive(true);
                summon2.Play();
                damaudio.Play();
                if (hp > 10)
                {
                    hp--;
                }

            }

            if (player_animator4.GetBool("isSkill") == true)
            {
                summon.gameObject.SetActive(true);
                summon.Play();
                damaudio.Play();
                hp = hp - 10;


            }

        }



    }
}
