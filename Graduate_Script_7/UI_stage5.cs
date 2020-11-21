using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_stage5 : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeFirstScene()
    {
        SceneManager.LoadScene("08.FinalStage");
        Time.timeScale = 1.0f;
    }
}
