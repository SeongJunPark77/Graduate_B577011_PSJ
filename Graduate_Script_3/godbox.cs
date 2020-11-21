using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class godbox : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bigbro;

    public ParticleSystem summon;

    // Start is called before the first frame update
    void Start()
    {
        summon.gameObject.SetActive(false);
    }



    // Update is called once per frame
    void Update()
    {
        summon.transform.position = bigbro.transform.position + new Vector3(0, 0.7f, 0);
    }



    void OnTriggerEnter(Collider col)
    {
        //godpoint god = GameObject.Find("godpoint").GetComponent<godpoint>();

        if (col.gameObject == bigbro)
        {
            GameObject.Find("potion_get_sound").GetComponent<AudioSource>().Play();
            godpoint.god_point++;

            summon.gameObject.SetActive(true);
            summon.Play();

            Destroy(gameObject);
        }


        Destroy(gameObject, 10f);
    }
}
