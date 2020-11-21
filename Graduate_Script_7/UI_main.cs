using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_main : MonoBehaviour
{
    GameObject back1;
    GameObject back2;
    GameObject back3;
    GameObject back4;
    GameObject back5;

    GameObject mix;
    GameObject final;
    // Start is called before the first frame update
    void Start()
    {
        back1 = GameObject.Find("singlecanvas").transform.Find("back1").gameObject;
        back2 = GameObject.Find("singlecanvas").transform.Find("back2").gameObject;
        back3 = GameObject.Find("singlecanvas").transform.Find("back3").gameObject;
        back4 = GameObject.Find("singlecanvas").transform.Find("back4").gameObject;
        back5 = GameObject.Find("singlecanvas").transform.Find("back5").gameObject;

        mix = GameObject.Find("singlecanvas").transform.Find("mix").gameObject;
        final = GameObject.Find("singlecanvas").transform.Find("finalscroll").gameObject;
    }
    public void ChangeFirstScene()
    {
        mix.SetActive(false);
        final.SetActive(false);

        back1.SetActive(true);
        back2.SetActive(true);
        back3.SetActive(true);
        back4.SetActive(true);
        back5.SetActive(true);

        GameObject.Find("exit_sound").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("07.Stage4");
    }
}
