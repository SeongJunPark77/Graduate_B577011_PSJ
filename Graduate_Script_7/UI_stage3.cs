using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_stage3 : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeFirstScene()
    {
        SceneManager.LoadScene("06.Stage3");
        Time.timeScale = 1.0f;
    }
}
