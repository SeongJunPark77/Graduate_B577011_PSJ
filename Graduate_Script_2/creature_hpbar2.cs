using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class creature_hpbar2 : MonoBehaviour
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
        witch_creature2 witch = GameObject.Find("creature2").GetComponent<witch_creature2>();

        Hpbar.fillAmount = witch.hp / 300f;

        if (witch.hp <= 0)
        {
            Destroy(gameObject);
        }


    }
}
