using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class final_stor1 : MonoBehaviour
{
    int talkCnt = 7;       // 대화의 총 갯수를 설정해줍니다.
    int strCnt = 0;         // 이 변수가 하나씩 커져가면서 대화를 진행합니다.
    string[] talking;          // 대화 내용을 저장할 공간입니다.
    public Text txt;        // Text 오브젝트에 접근하기
    public Image[] charactors;
    public Image showText;
    int[] showCnt;
    // Start is called before the first frame update
    void Start()
    {
        talking = new string[talkCnt]; // 대화 저장 공간을 초기화해줍니다.
        showCnt = new int[talkCnt];
        txt = GameObject.Find("Canvas").transform.Find("ttext").GetComponent<Text>();
        // 캔버스 오브젝트 아래 자식 오브젝트로 있는 Text를 호출합니다.
        showText = GameObject.Find("Canvas").transform.Find("talkScreen").GetComponent<Image>();
        // 캔버스 오브젝트 아래 자식 오브젝트로 있는 talkScreen을 호출합니다.

        charactors = new Image[5];  // 이미지 호출할 배열을 만듭니다.  // 적
        charactors[0] = GameObject.Find("Canvas").transform.Find("monster1").GetComponent<Image>();
        charactors[1] = GameObject.Find("Canvas").transform.Find("wizard1").GetComponent<Image>();
        charactors[2] = GameObject.Find("Canvas").transform.Find("knight1").GetComponent<Image>();
        charactors[3] = GameObject.Find("Canvas").transform.Find("warlord1").GetComponent<Image>();
        charactors[4] = GameObject.Find("Canvas").transform.Find("nothing1").GetComponent<Image>();
        // 각 배열에 오브젝트를 연결합니다.
        // 각 배열에 오브젝트를 연결합니다.
        // 등장 인물이 많다면 여러개를 생성해야 합니다.

        initialized();      // 대화를 설정하는 함수입니다.
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 0.0f;
        if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Jump"))
        {
            GameObject.Find("exit_sound").GetComponent<AudioSource>().Play();
            strCnt++;

            // '엔터'나 '스페이스바'를 누르면 카운트가 올라갑니다.
        }

        if (strCnt == 6)
        {
            Time.timeScale = 1.0f;

            SceneManager.UnloadSceneAsync("final_stor1");
            SceneManager.LoadScene("08.FinalStage");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }


        showAll();

    }

    void showAll()
    {
        showText.gameObject.SetActive(true);
        for (int i = 0; i < 5; i++)      // 등장인물의 수만큼을 써줍니다. 여기는 3명이 등장합니다.
        {
            charactors[i].gameObject.SetActive(false);      // 모든 오브젝트를 비활성화합니다.(사람 이미지)
        }
        charactors[showCnt[strCnt]].gameObject.SetActive(true);
        // 캐릭터의 showCnt라는 배열의 숫자에 대한 오브젝트만을 활성화합니다.
        txt.text = talking[strCnt];
        // strCnt의 차례에 맞춰 대화를 출력합니다.
    }

    void initialized()
    {
        // 대화 내용을 하나하나 추가합니다.
        talking[0] = "'결국 여길 찾아낸건가...'";
        talking[1] = "'이봐 너가 눈의 마녀야?'";
        talking[2] = "'눈의 마녀...? 무슨 소릴 하는거지 날 죽이러 온거면 덤벼'";
        talking[3] = "'저흰 당장 당신과 싸울 생각이 없어요'";
        talking[4] = "'너가 여기까지 오면서 내 아이들을 죽인걸 모를까봐?'";
        talking[5] = "'하아 이게 아닌데..'";
        talking[6] = "보스 스테이지로 진입합니다..";

        ////////////////////////////////////////

        //// 캐릭터의 등장 순서를 설정합니다.
        showCnt[0] = 0;     // 적
        showCnt[1] = 2;
        showCnt[2] = 0;
        showCnt[3] = 1;
        showCnt[4] = 0;
        showCnt[5] = 3;
        showCnt[6] = 4;

        // 순서로 이루어지는 대화
    }
}
