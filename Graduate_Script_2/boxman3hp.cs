using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxman3hp : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Hpbar;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        goblin Boss = GameObject.Find("Goblin").GetComponent<goblin>();
        Hpbar.fillAmount = Boss.hp / 1000f;
    }
}
