using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witch_finlaskilll : MonoBehaviour
{
    public ParticleSystem summon;
    public GameObject union;
    public GameObject archer;
    public GameObject wizard;
    public GameObject knight;
    public GameObject warlord;
    // Start is called before the first frame update
    void Start()
    {
        summon.gameObject.SetActive(false);
    }
    void OnTriggerStay(Collider c)
    {
        //Damage aratk = GameObject.Find("Damage").GetComponent<Damage>();

        if (c.gameObject == archer)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            archerhp.archer_hp = archerhp.archer_hp - 2f;
        }
        if (c.gameObject == wizard)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            wizardhp.wizard_hp = wizardhp.wizard_hp - 2f;
        }
        if (c.gameObject == knight)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            knighthp.knight_hp = knighthp.knight_hp - 2f;
        }
        if (c.gameObject == warlord)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            warlordhp.warlord_hp = warlordhp.warlord_hp - 2f;
        }
        Destroy(gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        summon.transform.position = union.transform.position + new Vector3(0, 0.7f, 0);
    }
}
