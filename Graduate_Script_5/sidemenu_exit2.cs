using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sidemenu_exit2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void click()
    {
        GameObject.Find("sssound").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("06.Stage3_1");
    }
}
