using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject single;
    void Awake()
    {
        single = GameObject.Find("singlecanvas");

        Destroy(single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
