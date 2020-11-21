using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scroll_story : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject final;
    void Awake()
    {
        final = GameObject.Find("singlecanvas").transform.Find("finalscroll").gameObject;

        if(final.activeSelf==true)
        {
            SceneManager.LoadScene("scroll_stage", LoadSceneMode.Additive);
        }
        else if(final.activeSelf==false)
        {
            SceneManager.LoadScene("scroll_stage2", LoadSceneMode.Additive);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
