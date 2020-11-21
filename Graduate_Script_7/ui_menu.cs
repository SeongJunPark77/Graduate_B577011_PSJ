using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui_menu : MonoBehaviour
{
    public GameObject finalfade;
    // Start is called before the first frame updat
    GameObject back1;
    GameObject back2;
    GameObject back3;
    GameObject back4;
    GameObject back5;

    GameObject mix;

    void Start()
    {
        back1 = GameObject.Find("singlecanvas").transform.Find("back1").gameObject;
        back2 = GameObject.Find("singlecanvas").transform.Find("back2").gameObject;
        back3 = GameObject.Find("singlecanvas").transform.Find("back3").gameObject;
        back4 = GameObject.Find("singlecanvas").transform.Find("back4").gameObject;
        back5 = GameObject.Find("singlecanvas").transform.Find("back5").gameObject;
        mix = GameObject.Find("singlecanvas").transform.Find("mix").gameObject;
        mix.SetActive(false);
        finalfade.SetActive(false);
      
    }

    // Update is called once per frame
    void Update()
    {
        if (back1.activeSelf == false && back2.activeSelf == false && back3.activeSelf == false &&
            back4.activeSelf == false && back5.activeSelf == false)
        {

            mix.SetActive(true);
        }
        else if(back1.activeSelf == false || back2.activeSelf == false || back3.activeSelf == false ||
            back4.activeSelf == false || back5.activeSelf == false)
        {
            mix.SetActive(false);
        }
    }

    public void onbuttonclick()
    {
        GameObject.Find("exit_sound").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("04.Gameover");
    }
}
