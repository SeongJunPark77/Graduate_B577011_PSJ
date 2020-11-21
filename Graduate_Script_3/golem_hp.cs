using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class golem_hp : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Hpbar;


    // Update is called once per frame
    void Update()
    {
        bossHP();
    }

    void bossHP()
    {
        golem_main Boss = GameObject.Find("golem").GetComponent<golem_main>();

        Hpbar.fillAmount = Boss.hp / 2250f;

        if (Boss.hp <= 0)
        {
            Destroy(gameObject);
        }


    }
}
