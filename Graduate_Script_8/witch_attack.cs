using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witch_attack : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePos;

    public GameObject player;
    Animator player_animator;
    // Start is called before the first frame update
    void Start()
    {
        player_animator = player.GetComponent<Animator>();

        InvokeRepeating("witch", 1, 1);
    }

    // Update is called once per frame
    void witch()
    {
        witch_main witch = GameObject.Find("Witch01").GetComponent<witch_main>();
        if (witch.hp <= 3500 && witch.hp > 2100)
        {
            if (player_animator.GetBool("isSkill") == true)
            {
                Instantiate(Bullet, FirePos.transform.position + new Vector3(0, 0.3f, 0), FirePos.transform.rotation);

            }
        }
    }

    void Update()
    {
        
    }
}
