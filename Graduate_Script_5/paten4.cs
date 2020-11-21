using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class paten4 : MonoBehaviour
{
    // Start is called before the first frame update
    public Image b;
    public Text c;
    float timeSpan;
    float checkTime;
    void Start()
    {
        timeSpan = 0.0f;
        checkTime = 1.2f;

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
            Color colorb = c.color;
            colorb.a -= 0.007f;
            c.color = colorb;
            Color color = b.color;
            color.a -= 0.007f;
            b.color = color;
        }
    }
}
