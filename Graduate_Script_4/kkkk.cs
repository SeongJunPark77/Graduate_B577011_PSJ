using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kkkk : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject endendendend;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        endendendend = GameObject.Find("endend").transform.Find("enddd").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (endendendend.activeSelf == false)
        {
            animator.SetBool("isfail", true);
        }
    }
}
