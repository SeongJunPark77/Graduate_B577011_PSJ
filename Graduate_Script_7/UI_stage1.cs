using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_stage1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeFirstScene()
    {
        SceneManager.LoadScene("03.MainStage");
        Time.timeScale = 1.0f;
    }
}
