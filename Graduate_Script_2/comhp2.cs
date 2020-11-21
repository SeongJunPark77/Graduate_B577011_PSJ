using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class comhp2 : MonoBehaviour
{
    // Start is called before the first frame update
  
    public Image Hpbar2;
  
    public float comhp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            
            Wizard();
       
    }
    void Wizard()
    {
       
        //wizardhp aaa2 = GameObject.Find("wizardhp").GetComponent<wizardhp>();
        comhp = wizardhp.wizard_hp;
        Hpbar2.fillAmount = comhp / 100f;

    }
}
