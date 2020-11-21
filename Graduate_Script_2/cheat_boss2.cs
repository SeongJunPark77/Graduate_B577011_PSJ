using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheat_boss2 : MonoBehaviour
{
    public void clicked()
    {
        boss2scri witch = GameObject.Find("boss2").GetComponent<boss2scri>();

        

        if(witch.barrier>0)
        {
            witch.barrier = witch.barrier - 150;
        }
        else if(witch.barrier <=0)
        {
            witch.hp = witch.hp - 250;
        }
    }
}
