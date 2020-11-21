using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witch_meteocircle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aboss;

    float timeSpan;
    float checkTime;

    void Start()
    {
        timeSpan = 0.0f;
        checkTime = 0.8f;
    }


    // Update is called once per frame
    void Update()
    {
        timeSpan += Time.deltaTime;

        if (timeSpan < checkTime)
        {
            this.transform.localScale += new Vector3(0.03f, 0, 0.03f);
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject == aboss)
        {
            Destroy(gameObject,0.6f);
        }

        Destroy(gameObject, 10f);
    }
}
