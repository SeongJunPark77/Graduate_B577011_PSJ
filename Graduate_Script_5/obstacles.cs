using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    float timeSpan;
    float checkTime;
    float limitTime;

    void Start()
    {
        timeSpan = 0.0f;
        checkTime = 0.4f;
        limitTime = 0.8f;

    }

    void Update()
    {
        timeSpan += Time.deltaTime;

        if (timeSpan <= checkTime)
        {
            this.transform.position += new Vector3(0.25f, 0, 0);
        }
        else if (timeSpan > checkTime)
        {
            this.transform.position += new Vector3(-0.25f, 0, 0);

            if (timeSpan >= limitTime)
            {
                timeSpan = 0.0f;
            }
        }
    }
}
