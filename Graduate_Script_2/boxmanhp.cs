using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxmanhp : MonoBehaviour
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
        boxman Boss = GameObject.Find("boxman").GetComponent<boxman>();

        Hpbar.fillAmount = Boss.hp / 10f;

        if (Boss.hp <= 0)
        {
            Destroy(gameObject);
        }


    }
}
