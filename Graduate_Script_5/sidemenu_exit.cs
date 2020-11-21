using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sidemenu_exit : MonoBehaviour
{
    // Start is called before the first frame update

    public void click()
    {
        GameObject.Find("sssound").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("05.Stage2_1");
    }
}
