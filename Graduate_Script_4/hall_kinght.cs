using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hall_kinght : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject me;
    public ParticleSystem summon;
    public int hp = 100;

    public GameObject player_1;
    Animator player_animator;
    void Start()
    {
        player_animator = player_1.GetComponent<Animator>();
        summon.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            me.SetActive(false);
        }
    }

    void OnTriggerStay(Collider c)
    {
        Vector3 pos = c.GetComponent<Transform>().position;
        summon.transform.position = this.transform.position + new Vector3(0, 1, 0);
     
            if (c.gameObject == player)
            {
                if (player_animator.GetBool("isAttacking") == true)
                {
                GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
                summon.gameObject.SetActive(true);
                    summon.Play();
                    hp = hp - 10;
                }
            }
        
    }
}
