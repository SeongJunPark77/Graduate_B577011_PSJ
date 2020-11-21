using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class commp2 : MonoBehaviour
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
        Wizard();
    }

    void Wizard()
    {
        //wizardmp aaa2 = GameObject.Find("wizardmp").GetComponent<wizardmp>();

        commp = wizardmp.wizard_mp;

        CommonMpbar.fillAmount = commp / 10f;
    }
}
