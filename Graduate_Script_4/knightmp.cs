using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class knightmp : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Mpbar;
    public static int knight_mp;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Knightmp();
    }

    void Knightmp()
    {
        Mpbar.fillAmount = knight_mp / 10f;
    }
}
