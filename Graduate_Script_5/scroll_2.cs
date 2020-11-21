using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll_2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bigbro;
    GameObject scroll2;
    GameObject back2;

    float timeSpan;
    float checkTime;
    float limitTime;
    void Start()

    {
        back2 = GameObject.Find("singlecanvas").transform.Find("back2").gameObject;
        scroll2 = GameObject.Find("singlecanvas").transform.Find("scroll2").gameObject;
        timeSpan = 0.0f;
        checkTime = 1.0f;
        limitTime = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeSpan += Time.deltaTime;
        if (Time.timeScale == 1.0f)
        {
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
    }

    void OnTriggerEnter(Collider c)
    {

        if (c.gameObject == bigbro)
        {
            GameObject.Find("scroll_sound").GetComponent<AudioSource>().Play();
            scroll2.SetActive(true);
            back2.SetActive(false);
            Destroy(gameObject);
        }
    }
}
