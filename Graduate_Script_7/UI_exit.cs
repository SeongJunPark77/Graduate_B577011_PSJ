using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_exit : MonoBehaviour
{
    public GameObject UIMAin;

    // Start is called before the first frame update
    public void clicked()
    {
        UIMAin.SetActive(false);
    }
}
