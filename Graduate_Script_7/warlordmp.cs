using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class warlordmp : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Mpbar;
    public static int warlord_mp;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Warlordmp();
    }

    void Warlordmp()
    {
        Mpbar.fillAmount = warlord_mp / 10f;
    }
}
