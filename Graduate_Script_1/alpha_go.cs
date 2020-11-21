using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class alpha_go : MonoBehaviour
{
    public Image b;
    float timeSpan;
    float checkTime;
    float limitTime;
    // Start is called before the first frame update
    void Start()
    {
        Color color = b.color;
        color.a = 0f;
        b.color = color;

        timeSpan = 0.0f;
        checkTime = 1.0f;
        limitTime = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeSpan += Time.deltaTime;

        

        if (Time.timeScale == 1.0)
        {

            if (timeSpan < checkTime)
            {
                Color color = b.color;
                color.a += 0.01f;
                b.color = color;
            }
            else if (timeSpan >= checkTime)
            {
                Color color = b.color;
                color.a -= 0.01f;
                b.color = color;
                if (timeSpan >= limitTime)
                {
                    timeSpan = 0.0f;
                }
            }
        }
    }
}
