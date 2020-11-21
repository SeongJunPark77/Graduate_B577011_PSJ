using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portaleffect : MonoBehaviour
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
                this.transform.localScale += new Vector3(0.001f, 0.001f, 0.001f);
            }
            else if (timeSpan >= checkTime)
            {
                this.transform.localScale += new Vector3(-0.001f, -0.001f, -0.001f);

                if (timeSpan >= limitTime)
                {
                    timeSpan = 0.0f;
                }
            }
        }
    }
}
