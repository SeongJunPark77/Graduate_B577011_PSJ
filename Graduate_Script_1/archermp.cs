using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class archermp : MonoBehaviour
{
    // Start is called before the first frame update

    public Image Mpbar;
    public static int archer_mp;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Archermp();
    }

    void Archermp()
    {
        Mpbar.fillAmount = archer_mp / 10f;
    }
}
