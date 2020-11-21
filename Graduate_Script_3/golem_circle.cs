using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golem_circle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aboss;

    float timeSpan;
    float checkTime;

    void Start()
    {
        timeSpan = 0.0f;
        checkTime = 1.6f;
    }


    // Update is called once per frame
    void Update()
    {
        timeSpan += Time.deltaTime;
        if (Time.timeScale == 1.0f)
        {
            if (timeSpan < checkTime)
            {
                this.transform.localScale += new Vector3(0.02f, 0, 0.02f);
            }
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject == aboss)
        {
            Destroy(gameObject, 2.7f);
        }

        Destroy(gameObject, 10f);
    }
}
