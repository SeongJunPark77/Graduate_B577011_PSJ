using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ddddd : MonoBehaviour
{
    GameObject single;
    void Awake()
    {
        single = GameObject.Find("endend");

        Destroy(single);
    }
}
