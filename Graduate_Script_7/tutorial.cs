using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class tutorial : MonoBehaviour
{

    public Text text1;
    public Text text1_1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;

    public Text text6;


    // Start is called before the first frame update
    void Awake()
    {
        text1.gameObject.SetActive(true);
        text1_1.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
        text3.gameObject.SetActive(false);
        text4.gameObject.SetActive(false);
        text5.gameObject.SetActive(false);
        text6.gameObject.SetActive(false);
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
