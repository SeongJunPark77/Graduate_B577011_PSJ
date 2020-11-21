using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skip : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeFirstScene()
    {
        GameObject.Find("skip_sound").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("03.MainStage");
    }
}
