﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class main_story2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        SceneManager.LoadScene("main_sto2", LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
