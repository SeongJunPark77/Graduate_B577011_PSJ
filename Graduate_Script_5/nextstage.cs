using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextstage : MonoBehaviour
{
    public GameObject aboss;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == aboss)
        {
            SceneManager.LoadScene("03.MainStage");

        }
    }
}
