using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheat_snow : MonoBehaviour
{

    public void clicked()
    {
        boss witch = GameObject.Find("SnowTiger").GetComponent<boss>();

        witch.hp = witch.hp - 300;
    }
}
