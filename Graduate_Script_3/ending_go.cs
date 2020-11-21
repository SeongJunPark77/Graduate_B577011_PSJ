using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ending_go : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject final;
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        final = GameObject.Find("singlecanvas").transform.Find("finalscroll").gameObject;
        witch_main witch = GameObject.Find("Witch01").GetComponent<witch_main>();
        if (witch.hp <= 0)
        {
            if (final.activeSelf == true)
            {
                SceneManager.LoadScene("09.Ending");
            }
            else if (final.activeSelf == false)
            {
                SceneManager.LoadScene("09.Ending_2");
            }
        }
    }
}
