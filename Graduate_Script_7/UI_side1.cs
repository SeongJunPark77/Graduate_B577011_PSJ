using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI_side1 : MonoBehaviour
{
    GameObject back1;
    GameObject back2;
    GameObject back3;
    GameObject back4;
    GameObject back5;

    GameObject back6;
    GameObject back7;
    GameObject back8;
    GameObject back9;
    GameObject back0;

    GameObject mix;
    GameObject final;
    // Start is called before the first frame update
    void Start()
    {
        back1 = GameObject.Find("singlecanvas").transform.Find("scroll1").gameObject;
        back2 = GameObject.Find("singlecanvas").transform.Find("scroll2").gameObject;
        back3 = GameObject.Find("singlecanvas").transform.Find("scroll3").gameObject;
        back4 = GameObject.Find("singlecanvas").transform.Find("scroll4").gameObject;
        back5 = GameObject.Find("singlecanvas").transform.Find("scroll5").gameObject;

        back6 = GameObject.Find("singlecanvas").transform.Find("back1").gameObject;
        back7 = GameObject.Find("singlecanvas").transform.Find("back2").gameObject;
        back8 = GameObject.Find("singlecanvas").transform.Find("back3").gameObject;
        back9 = GameObject.Find("singlecanvas").transform.Find("back4").gameObject;
        back0 = GameObject.Find("singlecanvas").transform.Find("back5").gameObject;

        mix = GameObject.Find("singlecanvas").transform.Find("mix").gameObject;
        final = GameObject.Find("singlecanvas").transform.Find("finalscroll").gameObject;
    }
    // Start is called before the first frame update
    public void ChangeFirstScene()
    {
        back1.SetActive(false);
        back2.SetActive(false);
        back3.SetActive(false);
        back4.SetActive(false);
        back5.SetActive(false);
        back6.SetActive(false);
        back7.SetActive(false);
        back8.SetActive(false);
        back9.SetActive(false);
        back0.SetActive(false);

        mix.SetActive(false);
        final.SetActive(true);


        GameObject.Find("exit_sound").GetComponent<AudioSource>().Play();

        SceneManager.LoadScene("07.Stage4");
    }
}
