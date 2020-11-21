using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coli : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    public GameObject a4;
    public GameObject a5;

    void Start()
    {
        Physics.IgnoreCollision(a1.GetComponent<Collider>(), a2.GetComponent<Collider>());
        Physics.IgnoreCollision(a1.GetComponent<Collider>(), a3.GetComponent<Collider>());
        Physics.IgnoreCollision(a1.GetComponent<Collider>(), a4.GetComponent<Collider>());
        Physics.IgnoreCollision(a1.GetComponent<Collider>(), a5.GetComponent<Collider>());
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == a2)
        {
            Physics.IgnoreCollision(a1.GetComponent<Collider>(), a2.GetComponent<Collider>());
        }
        if (col.gameObject == a3)
        {
            Physics.IgnoreCollision(a1.GetComponent<Collider>(), a3.GetComponent<Collider>());
        }
        if (col.gameObject == a4)
        {
            Physics.IgnoreCollision(a1.GetComponent<Collider>(), a4.GetComponent<Collider>());
        }
        if (col.gameObject == a5)
        {
            Physics.IgnoreCollision(a1.GetComponent<Collider>(), a5.GetComponent<Collider>());
        }
    }

    void OnTriggerStay(Collider col)
    {
        if(col.gameObject == a2)
        {
            Physics.IgnoreCollision(a1.GetComponent<Collider>(), a2.GetComponent<Collider>());
        }
        if (col.gameObject == a3)
        {
            Physics.IgnoreCollision(a1.GetComponent<Collider>(), a3.GetComponent<Collider>());
        }
        if (col.gameObject == a4)
        {
            Physics.IgnoreCollision(a1.GetComponent<Collider>(), a4.GetComponent<Collider>());
        }
        if (col.gameObject == a5)
        {
            Physics.IgnoreCollision(a1.GetComponent<Collider>(), a5.GetComponent<Collider>());
        }
    }
}
