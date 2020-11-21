using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endendend : MonoBehaviour
{
    public static endendend instance;

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
