using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class comhp3 : MonoBehaviour
{
    // Start is called before the first frame update
   
    public Image Hpbar3;

    public float comhp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

            Knight();
    
    }
    void Knight()
    {
        

        //knighthp aaa3 = GameObject.Find("knighthp").GetComponent<knighthp>();
        comhp = knighthp.knight_hp;
        Hpbar3.fillAmount = comhp / 350f;

    }
}
