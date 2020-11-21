using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class final_stor3 : MonoBehaviour
{
    // Start is called before the first frame update
    int talkCnt = 11;       // 대화의 총 갯수를 설정해줍니다.
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

        charactors = new Image[6];  // 이미지 호출할 배열을 만듭니다.  // 적
        charactors[0] = GameObject.Find("Canvas").transform.Find("monster1").GetComponent<Image>();
        charactors[1] = GameObject.Find("Canvas").transform.Find("wizard1").GetComponent<Image>();
        charactors[2] = GameObject.Find("Canvas").transform.Find("knight1").GetComponent<Image>();
        charactors[3] = GameObject.Find("Canvas").transform.Find("warlord1").GetComponent<Image>();
        charactors[4] = GameObject.Find("Canvas").transform.Find("nothing1").GetComponent<Image>();
        charactors[5] = GameObject.Find("Canvas").transform.Find("monster2").GetComponent<Image>();
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

        if (strCnt == 10)
        {
            Time.timeScale = 1.0f;

            SceneManager.UnloadSceneAsync("final_stor3");
            SceneManager.LoadScene("08.FinalStage2");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }


        showAll();

    }

    void showAll()
    {
        showText.gameObject.SetActive(true);
        for (int i = 0; i < 6; i++)      // 등장인물의 수만큼을 써줍니다. 여기는 3명이 등장합니다.
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
        talking[0] = "'이곳엔 어쩐일로...?'";
        talking[1] = "'연기는 그만하지, 이런걸 지나가다가 봐서 말이야'";
        talking[2] = "";
        talking[3] = "'크큭...눈치 챈건가'";
        talking[4] = "'그래 그럼 더이상 숨길 필욘 없겠지, 난 마왕님의 부하고 마왕님이 죽기 직전 명령을 내리셨다'";
        talking[5] = "'어떤 명령이죠?'";
        talking[6] = "'너희는 필히 저주를 풀러 이곳으로 올거고, 나는 너희를 속여 영원한 절망에 빠지게 하는 것이지'";
        talking[7] = "'하지만 글렀군, 우리가 다 눈치챘으니'";
        talking[8] = "'그래 하지만 내가 여기서 너희를 죽인다면 마왕님의 복수를 할 수 있는거지!'";
        talking[9] = "'마음대로 될거 같냐? 너를 죽이고 마을 사람들을 구하러 가겠어'";
        talking[10] = "보스 스테이지로 진입합니다..";
        ////////////////////////////////////////

        //// 캐릭터의 등장 순서를 설정합니다.
        showCnt[0] = 0;     // 적
        showCnt[1] = 2;
        showCnt[2] = 3;
        showCnt[3] = 0;
        showCnt[4] = 5;
        showCnt[5] = 1;
        showCnt[6] = 5;
        showCnt[7] = 2;
        showCnt[8] = 5;
        showCnt[9] = 2;
        showCnt[10] = 4;

        // 순서로 이루어지는 대화
    }
}
