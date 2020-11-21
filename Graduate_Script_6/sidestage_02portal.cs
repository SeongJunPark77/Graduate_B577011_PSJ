using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sidestage_02portal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aboss;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == aboss)
        {
            //int ran = Random.Range(4, 9);
            SceneManager.LoadScene("SideStage_02");
            Destroy(gameObject);
        }
    }
}
