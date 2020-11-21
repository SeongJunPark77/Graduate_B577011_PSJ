using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class commp3 : MonoBehaviour
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
        Knight();
    }

    void Knight()
    {
        //knightmp aaa3 = GameObject.Find("knightmp").GetComponent<knightmp>();

        commp = knightmp.knight_mp;

        CommonMpbar.fillAmount = commp / 10f;
    }
}
