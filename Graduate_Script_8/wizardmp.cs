using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class wizardmp : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Mpbar;
    public static int wizard_mp;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Wizardmp();
    }

    void Wizardmp()
    {
        Mpbar.fillAmount = wizard_mp / 10f;
    }
}
