using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class comhp4 : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Image Hpbar4;
    public float comhp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

            Warlord();
      
    }
    void Warlord()
    {
        
       

        //warlordhp aaa4 = GameObject.Find("warlordhp").GetComponent<warlordhp>();
        comhp = warlordhp.warlord_hp;
        Hpbar4.fillAmount = comhp / 140f;

    }
}
