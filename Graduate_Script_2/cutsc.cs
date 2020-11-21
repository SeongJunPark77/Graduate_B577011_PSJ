using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cutsc : MonoBehaviour
{
    //// Start is called before the first frame update
    float timeSpan;
    float checkTime;
    float limitTime;

    public Image b;
    public Image c;
    public Text d;
    void Awake()
    {
        this.GetComponent<Transform>().SetParent(GameObject.Find("UI").GetComponent<Transform>());
        Color color = b.color;
        color.a = 0f;
        b.color = color;

        Color colorc = c.color;
        colorc.a = 0f;
        c.color = colorc;

        Color colord = d.color;
        colord.a = 0f;
        d.color = colord;

        timeSpan = 0.0f;
        checkTime = 0.24f;
        limitTime = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        Color color = b.color;
        Color colorc = c.color;
        Color colord = d.color;

        timeSpan += Time.deltaTime;

        if (timeSpan < checkTime)
        {
            color.a += 0.14f;
            b.color = color;

            colorc.a += 0.14f;
            c.color = colorc;

            colord.a += 0.14f;
            d.color = colord;
            this.transform.position += new Vector3(12f, 0, 0);
        }
        else if (timeSpan >= checkTime)
        {
            color.a -= 0.065f;
            b.color = color;

            colorc.a -= 0.065f;
            c.color = colorc;

            colord.a -= 0.065f;
            d.color = colord;

            this.transform.position += new Vector3(0.7f, 0, 0);

            if (timeSpan >= limitTime)
            {
                return;
            }
        }
    }
}
