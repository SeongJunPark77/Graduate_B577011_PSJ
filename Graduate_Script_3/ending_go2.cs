using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ending_go2 : MonoBehaviour
{
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {

        witch_main witch = GameObject.Find("Witch01").GetComponent<witch_main>();
        if (witch.hp <= 0)
        {

                SceneManager.LoadScene("09.Ending_3");
            

        }
    }
}
