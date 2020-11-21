using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class witch_hpbar : MonoBehaviour
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
        witch_main witch = GameObject.Find("Witch01").GetComponent<witch_main>();

        Hpbar.fillAmount = witch.hp / 3500f;

        if (witch.hp <= 0)
        {
            Destroy(gameObject);
        }


    }
}
