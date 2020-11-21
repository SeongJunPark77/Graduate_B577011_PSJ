using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll_5 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bigbro;
    GameObject scroll5;
    GameObject back5;


    void Start()

    {
        back5 = GameObject.Find("singlecanvas").transform.Find("back5").gameObject;
        scroll5 = GameObject.Find("singlecanvas").transform.Find("scroll5").gameObject;


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

            back5.SetActive(false);
            scroll5.SetActive(true);

            Destroy(gameObject);
        }
    }
}
