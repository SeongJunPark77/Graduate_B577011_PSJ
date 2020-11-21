using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll1_back : MonoBehaviour
{
    // Start is called before the first frame update
    public static scroll1_back instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(this.gameObject);

    }


}
