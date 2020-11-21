using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skilleffect2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Bullet;
    public Transform FirePos;

    public GameObject Bullet2;
    public Transform FirePos2;


    public GameObject player;
    Animator player_animator;

    public GameObject player2;
    Animator player_animator2;

    bool skilluse = true;

    void Awake()
    {
        

        player_animator = player.GetComponent<Animator>();
        player_animator2 = player2.GetComponent<Animator>();
    }

    void Update()
    {
        //archermp Armp = GameObject.Find("archermp").GetComponent<archermp>();

        if (archermp.archer_mp <= -1)
        {
            skilluse = false;
        }
        else if (archermp.archer_mp > -1)
        {
            skilluse = true;
        }

        //wizardmp Wzmp = GameObject.Find("wizardmp").GetComponent<wizardmp>();

        if (wizardmp.wizard_mp <= -1)
        {
            skilluse = false;
        }
        else if (wizardmp.wizard_mp > -1)
        {
            skilluse = true;
        }

        if (skilluse)
        {
            if (player_animator.GetBool("isSkill") == true)
            {


                Instantiate(Bullet, FirePos.transform.position+new Vector3(0, 1.1f, 0), FirePos.transform.rotation);

            }

            if (player_animator2.GetBool("isSkill") == true)
            {
                Instantiate(Bullet2, FirePos.transform.position+ new Vector3(0, 0.8f, 0), FirePos.transform.rotation);

            }
        }

     


    }
}
