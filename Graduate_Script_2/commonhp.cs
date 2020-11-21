using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class commonhp : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Hpbar;
 
    public float comhp;
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        

            Archer();
       

    }

    void Archer()
    {
       
        //archerhp aaa1 = GameObject.Find("archerhp").GetComponent<archerhp>();

        comhp = archerhp.archer_hp;

        Hpbar.fillAmount = comhp / 100f;

    }

    

   

}
