using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll_4 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bigbro;
    GameObject scroll4;
    GameObject back4;
    float timeSpan;
    float checkTime;
    float limitTime;

    void Start()

    {
      

        back4 = GameObject.Find("singlecanvas").transform.Find("back4").gameObject;
        scroll4 = GameObject.Find("singlecanvas").transform.Find("scroll4").gameObject;
        timeSpan = 0.0f;
        checkTime = 1.0f;
        limitTime = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeSpan += Time.deltaTime;

        if (timeSpan < checkTime)
        {
            this.transform.position += new Vector3(0, -0.006f, 0);
        }
        else if (timeSpan >= checkTime)
        {
            this.transform.position += new Vector3(0, 0.006f, 0);

            if (timeSpan >= limitTime)
            {
                timeSpan = 0.0f;
            }
        }
    }

    void OnTriggerEnter(Collider c)
    {

        if (c.gameObject == bigbro)
        {
            GameObject.Find("scroll_sound").GetComponent<AudioSource>().Play();
            back4.SetActive(false);
            scroll4.SetActive(true);
            Destroy(gameObject);
        }
    }
}
