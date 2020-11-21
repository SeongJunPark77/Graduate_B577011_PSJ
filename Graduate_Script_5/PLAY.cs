using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAY : MonoBehaviour
{


    public void ChangeFirstScene()
    {
        GameObject.Find("skip_sound").GetComponent<AudioSource>().Play();


        SceneManager.LoadScene("Story");
    }
}
