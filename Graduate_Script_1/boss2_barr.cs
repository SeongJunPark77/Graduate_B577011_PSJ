using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss2_barr : MonoBehaviour
{
    // Start is called before the first frame update
    public Image barrbar;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bossHP();
    }

    void bossHP()
    {
        boss2scri witch = GameObject.Find("boss2").GetComponent<boss2scri>();
        barrbar.fillAmount = witch.barrier / 500f;

        if (witch.hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
