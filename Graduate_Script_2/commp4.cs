using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class commp4 : MonoBehaviour
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
        Warlord();
    }

    void Warlord()
    {
        //warlordmp aaa4 = GameObject.Find("warlordmp").GetComponent<warlordmp>();

        commp = warlordmp.warlord_mp;

        CommonMpbar.fillAmount = commp / 10f;
    }
}
