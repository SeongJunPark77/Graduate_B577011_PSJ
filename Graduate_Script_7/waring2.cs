using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waring2 : MonoBehaviour
{
    float timeSpan;
    float checkTime;
    public Image b;
    // Start is called before the first frame update
    void Start()
    {
        timeSpan = 0.0f;
        checkTime = 0.25f;
    }

    // Update is called once per frame
    void Update()
    {

        timeSpan += Time.deltaTime;

        if (timeSpan < checkTime)
        {
        }
        else if (timeSpan >= checkTime)
        {
            Color color = b.color;
            color.a -= 0.03f;
            b.color = color;
        }
    }
}
