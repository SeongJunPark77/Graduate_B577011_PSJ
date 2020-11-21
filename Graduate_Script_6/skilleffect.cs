using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skilleffect : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePos;

    public GameObject Bullet2;
    public Transform FirePos2;


    public GameObject player;
    Animator player_animator;

    public GameObject player2;
    Animator player_animator2;

    void Awake()
    {
        player_animator = player.GetComponent<Animator>();
        player_animator2 = player2.GetComponent<Animator>();
    }

    void Update()
    {

        if (player_animator.GetBool("isAttacking") == true)
        {
            Instantiate(Bullet, FirePos.transform.position+new Vector3(0,1.1f,0), FirePos.transform.rotation);

        }

        if (player_animator2.GetBool("isAttacking") == true)
        {
            Instantiate(Bullet2, FirePos.transform.position + new Vector3(0, 0.8f, 0), FirePos.transform.rotation);

        }



    }


}
