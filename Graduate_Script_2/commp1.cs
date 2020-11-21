using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class commp1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Image CommonMpbar;

    public int commp;   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Archer();
    }

    void Archer()
    {
        //archermp aaa1 = GameObject.Find("archermp").GetComponent<archermp>();

        commp = archermp.archer_mp;

       CommonMpbar.fillAmount = commp / 10f;
    }
}
