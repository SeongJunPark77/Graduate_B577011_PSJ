﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class potal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aboss;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == aboss)
        {
            //int ran = Random.Range(4, 9);
            SceneManager.LoadScene("05.Stage2");
            Destroy(gameObject);
        }
    }
}
