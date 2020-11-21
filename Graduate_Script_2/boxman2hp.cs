using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxman2hp : MonoBehaviour
{
    public Image Hpbar;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        boxman2 Boss = GameObject.Find("BOXMAN2").GetComponent<boxman2>();
        Hpbar.fillAmount = Boss.hp / 10f;

       
    }
}
