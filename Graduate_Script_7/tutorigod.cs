using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorigod : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bigbro;



    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerEnter(Collider col)
    {
        //godpoint god = GameObject.Find("godpoint").GetComponent<godpoint>();

        if (col.gameObject == bigbro)
        {
            
                godpoint.god_point = godpoint.god_point+4;
        

            Destroy(gameObject);
        }

    }
}
