using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class creature_hpbar : MonoBehaviour
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
        witch_creature witch = GameObject.Find("creature").GetComponent<witch_creature>();

        Hpbar.fillAmount = witch.hp / 300f;

        if (witch.hp <= 0)
        {
            Destroy(gameObject);
        }


    }
}
