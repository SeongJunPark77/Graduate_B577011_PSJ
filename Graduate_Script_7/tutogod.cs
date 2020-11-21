using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutogod : MonoBehaviour
{
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
     
            GameObject.Find("potion_get_sound").GetComponent<AudioSource>().Play();
            godpoint.god_point= godpoint.god_point+10;



            Destroy(gameObject);
        }

    }
}
