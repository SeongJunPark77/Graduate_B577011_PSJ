using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witch_ball : MonoBehaviour
{
    public ParticleSystem summon;
    public GameObject union;
    public GameObject aboss;
    public GameObject bboss;
    public GameObject cboss;
    public GameObject dboss;
    // Start is called before the first frame update
    void Start()
    {
        summon.gameObject.SetActive(false);
        this.transform.Translate(Vector3.forward * 0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        summon.transform.position = union.transform.position + new Vector3(0, 0.7f, 0);
        transform.Translate(Vector3.forward * 0.4f);
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject == aboss)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            Destroy(gameObject);
            archerhp.archer_hp = archerhp.archer_hp - 5;
        }

        if (c.gameObject == bboss)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            Destroy(gameObject);
            wizardhp.wizard_hp = wizardhp.wizard_hp - 5;
        }

        if (c.gameObject == cboss)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            Destroy(gameObject);
            knighthp.knight_hp = knighthp.knight_hp - 12;
        }

        if (c.gameObject == dboss)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            Destroy(gameObject);
            warlordhp.warlord_hp = warlordhp.warlord_hp - 8;
        }

        Destroy(gameObject, 0.3f);
    }
}
