using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witch_paten2 : MonoBehaviour
{
    public ParticleSystem summon;
    public GameObject union;
    // Start is called before the first frame update
    public float xMin;
    public float zMin;
    public float xMax;
    public float zMax;

    static float randX;
    static float randZ;
    static Vector3 target;

    public GameObject archer;
    public GameObject wizard;
    public GameObject knight;
    public GameObject warlord;
    void Start()
    {
        summon.gameObject.SetActive(false);
        InvokeRepeating("move_rand", 1, 3);
    }

    void move_rand()
    {
        randX = Random.Range(xMin, xMax);
        randZ = Random.Range(zMin, zMax);
        target = new Vector3(randX, 0, randZ);
    }

    void OnTriggerStay(Collider c)
    {
        if(c.gameObject == archer)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            archerhp.archer_hp = archerhp.archer_hp - 4;
        }

        if(c.gameObject == wizard)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            wizardhp.wizard_hp = wizardhp.wizard_hp - 4f;
        }

        if(c.gameObject == knight)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            knighthp.knight_hp = knighthp.knight_hp - 4f;
        }

        if(c.gameObject == warlord)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            warlordhp.warlord_hp = warlordhp.warlord_hp - 4f;
        }
    }

    void Update()
    {
        summon.transform.position = union.transform.position + new Vector3(0, 0.7f, 0);
        this.transform.Translate(target);
    }
}
