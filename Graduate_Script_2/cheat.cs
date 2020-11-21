using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clicked()
    {
        witch_main witch = GameObject.Find("Witch01").GetComponent<witch_main>();

        witch.hp = witch.hp - 500;
    }
}
