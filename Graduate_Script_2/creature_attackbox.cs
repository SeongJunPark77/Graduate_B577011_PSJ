using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creature_attackbox : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    Animator player_animator;

    public GameObject me;

    void Start()
    {
        me.SetActive(false);

        player_animator = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player_animator.GetBool("isSkill") == true)
        {

            me.SetActive(true);
        }
        else if (player_animator.GetBool("isSkill")==true)
        {
            me.SetActive(false);
        }
    }
}
