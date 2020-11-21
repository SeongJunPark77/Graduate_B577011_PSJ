using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameout : MonoBehaviour
{
    public GameObject bigbro;
    // Start is called before the first frame update

   void OnTriggerEnter(Collider c)
    {
        if(c.gameObject == bigbro)
        {

            bigbro.transform.position = new Vector3(6.06f, 1.4f, -0.72f);
        }
    }
}
