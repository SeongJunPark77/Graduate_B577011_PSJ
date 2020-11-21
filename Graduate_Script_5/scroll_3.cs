using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll_3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bigbro;
    GameObject scroll3;
    GameObject back3;


    void Start()

    {
        scroll3 = GameObject.Find("singlecanvas").transform.Find("scroll3").gameObject;
        back3 = GameObject.Find("singlecanvas").transform.Find("back3").gameObject;
     
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider c)
    {

        if (c.gameObject == bigbro)
        {
            GameObject.Find("scroll_sound").GetComponent<AudioSource>().Play();
            scroll3.SetActive(true);
            back3.SetActive(false);
            Destroy(gameObject);
        }
    }
}
