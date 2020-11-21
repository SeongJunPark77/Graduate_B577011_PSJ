using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hall_archer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject me;
    public int hp = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hp<=0)
        {
            me.SetActive(false);
        }
    }
}
