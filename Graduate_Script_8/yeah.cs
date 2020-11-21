using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yeah : MonoBehaviour
{
    float timeSpan;
    float checkTime;
    float limitTime;

    void Start()
    {
        timeSpan = 0.0f;
        checkTime = 2.0f;
        limitTime = 4.0f;

    }

    void Update()
    {
        timeSpan += Time.deltaTime;

        if (timeSpan < checkTime)
        {
            this.transform.position += new Vector3(0, 0, 0.1f);
        }
        else if (timeSpan >= checkTime)
        {
            this.transform.position += new Vector3(0,0, -0.1f);

            if (timeSpan >= limitTime)
            {
                timeSpan = 0.0f;
            }
        }
    }
}
