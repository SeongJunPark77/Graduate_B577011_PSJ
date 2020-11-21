using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class final_stor : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject final;
    void Awake()
    {
        final = GameObject.Find("singlecanvas").transform.Find("finalscroll").gameObject;
            if (final.activeSelf == true)
            {
                SceneManager.LoadScene("final_stor1", LoadSceneMode.Additive);
            }
            else if (final.activeSelf == false)
            {
                SceneManager.LoadScene("final_stor2", LoadSceneMode.Additive);
            }
   
    }
}
