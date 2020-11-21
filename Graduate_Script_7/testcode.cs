using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testcode : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Post;
    void Start()
    {
        Post = GameObject.Find("Archer_body01");

        this.GetComponent<SkinnedMeshRenderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
