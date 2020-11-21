using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss2_magicball : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aboss;
    public GameObject barr;

    public ParticleSystem summon;
    void Start()
    {
        summon.gameObject.SetActive(false);
        this.transform.Translate(Vector3.forward * 0.6f);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 0.4f);
    }

    void OnTriggerEnter(Collider c)
    {
        Vector3 pos = c.GetComponent<Transform>().position;
        summon.transform.position = pos + new Vector3(0, 1, 0);
        boss2scri witch = GameObject.Find("boss2").GetComponent<boss2scri>();
        if (c.gameObject == aboss)
        {
            summon.gameObject.SetActive(true);
            summon.Play();
            GameObject.Find("long_damage_sound").GetComponent<AudioSource>().Play();
            Destroy(gameObject);

            witch.hp = witch.hp - Damage.wizatk;
        }

        if (c.gameObject == barr)
        {
            Destroy(gameObject);
        }

        Destroy(gameObject, 0.3f);
    }
}
