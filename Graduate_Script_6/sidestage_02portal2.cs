using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sidestage_02portal2 : MonoBehaviour
{
    public GameObject aboss;
    public GameObject no;
    GameObject back3;
    void Start()

    {
        no.SetActive(false);
        back3 = GameObject.Find("singlecanvas").transform.Find("back5").gameObject;

    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == aboss)
        {
            if (back3.activeSelf == true)
            {
                //int ran = Random.Range(4, 9);
                SceneManager.LoadScene("SideStage_02");
                Destroy(gameObject);
            }
            else if (back3.activeSelf == false)
            {
                no.SetActive(true);
            }
        }
    }
}
