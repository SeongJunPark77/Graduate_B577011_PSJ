using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class endingportal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aboss;
    public GameObject no;
    GameObject finalscroll;

    void Awake()
    {
        no.SetActive(false);
        finalscroll = GameObject.Find("singlecanvas").transform.Find("finalscroll").gameObject;

    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == aboss)
        {
            if(finalscroll.activeSelf==true)
            {
                SceneManager.LoadScene("08.Final2");
                Destroy(gameObject);
            }
            else
            {
                no.SetActive(true);
                    
            }

        }
    }
}
