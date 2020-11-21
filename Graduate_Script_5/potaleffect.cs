using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potaleffect : MonoBehaviour
{
    // Start is called before the first frame update
    float timeSpan;
    float checkTime;
    float limitTime;

    void Start()
    {
        timeSpan = 0.0f;
        checkTime = 1.0f;
        limitTime = 2.0f;

    }

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
}
