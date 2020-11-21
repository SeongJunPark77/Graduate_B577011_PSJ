using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutosto3 : MonoBehaviour
{
    // Start is called before the first frame update
    int talkCnt = 3;      
    int strCnt = 0;     
    string[] talking;         
    public Text txt;        
    public Image[] charactors;
    public Image showText;
    int[] showCnt;
    // Start is called before the first frame update
    void Start()
    {
        talking = new string[talkCnt]; 
        showCnt = new int[talkCnt];
        txt = GameObject.Find("Canvas").transform.Find("ttext").GetComponent<Text>();

        showText = GameObject.Find("Canvas").transform.Find("talkScreen").GetComponent<Image>();


        charactors = new Image[3];  
        charactors[0] = GameObject.Find("Canvas").transform.Find("monster").GetComponent<Image>();
        charactors[1] = GameObject.Find("Canvas").transform.Find("archer").GetComponent<Image>();
        charactors[2] = GameObject.Find("Canvas").transform.Find("nothing").GetComponent<Image>();


        initialized();      
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 0.0f;
        if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Jump"))
        {
            GameObject.Find("exit_sound").GetComponent<AudioSource>().Play();
            strCnt++;


        }

        if (strCnt == 2)
        {
            Time.timeScale = 1.0f;

            SceneManager.UnloadSceneAsync("Tuto_sto3");


        }


        showAll();

    }

    void showAll()
    {
        showText.gameObject.SetActive(true);
        for (int i = 0; i < 3; i++)      
        {
            charactors[i].gameObject.SetActive(false);      
        }
        charactors[showCnt[strCnt]].gameObject.SetActive(true);

        txt.text = talking[strCnt];

    }

    void initialized()
    {

        talking[0] = "'크워워워!!!'";
        talking[1] = "'아까 잡은 녀석의 가족인가? 화가 잔뜩 나있네'";
        talking[2] = "";

        showCnt[0] = 0;    
        showCnt[1] = 1;
        showCnt[2] = 2;
    }
}
