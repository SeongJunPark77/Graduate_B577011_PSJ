using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpbar : MonoBehaviour
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
        boss Boss = GameObject.Find("SnowTiger").GetComponent<boss>();
        
        Hpbar.fillAmount = Boss.hp/ 1200f;

       if(Boss.hp<=0)
        {
            Destroy(gameObject);
        }
        

    }
}
