using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goblinarrow : MonoBehaviour
{
    public ParticleSystem summon;
    public GameObject union;
    // Start is called before the first frame update
    public GameObject archer;
    public GameObject wizard;
    public GameObject knight;
    public GameObject warlord;

    private void Awake()
    {
        summon.gameObject.SetActive(false);
    }

    void Update()
    {
        summon.transform.position = union.transform.position + new Vector3(0, 0.7f, 0);
        //프레임마다 오브젝트를 로컬좌표상에서 앞으로 1의 힘만큼 날아가라
        transform.Translate(Vector3.forward * 0.8f);
    }

    void OnTriggerEnter(Collider c)
    {
        //Damage aratk = GameObject.Find("Damage").GetComponent<Damage>();

        if (c.gameObject == archer)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            Destroy(gameObject);
            archerhp.archer_hp = archerhp.archer_hp - 5;
        }

        if (c.gameObject == wizard)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            Destroy(gameObject);
            wizardhp.wizard_hp = wizardhp.wizard_hp - 5;
        }

        if (c.gameObject == knight)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            Destroy(gameObject);
            knighthp.knight_hp = knighthp.knight_hp - 2;
        }

        if (c.gameObject == warlord)
        {
            Camera.main.GetComponent<camerashake>().ShakeCamera(1.0f);
            summon.gameObject.SetActive(true);
            summon.Play();
            Destroy(gameObject);
            warlordhp.warlord_hp = warlordhp.warlord_hp - 2;
        }

        Destroy(gameObject, 0.3f);
    }

}
