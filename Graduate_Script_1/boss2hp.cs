using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss2hp : MonoBehaviour
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

        boss2scri witch = GameObject.Find("boss2").GetComponent<boss2scri>();
        Hpbar.fillAmount = witch.hp / 1500f;

        if (witch.hp <= 0)
        {
            Destroy(gameObject);
        }


    }
}
